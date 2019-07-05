﻿using izibiz.COMMON;
using izibiz.CONTROLLER.Singleton;
using izibiz.MODEL.Data;
using izibiz.MODEL.DbModels;
using izibiz.SERVICES.serviceOib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubl_Invoice_2_1;

namespace izibiz.CONTROLLER.DAL
{
    public class InvoiceDal
    {

        public List<Invoices> getFaultyInvoices()
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                return dbContext.invoices.Where(inv => inv.direction == nameof(EI.Direction.OUT)
            && inv.status.Contains(nameof(EI.StatusType.LOAD))
            && inv.status.Contains(nameof(EI.SubStatusType.FAILED))).OrderByDescending(inv => inv.cDate).ToList();
            }
        }



        public Invoices getInvoice(string uuid, string direction)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                return dbContext.invoices.Where(inv => inv.direction == direction
            && inv.uuid == uuid).First();
            }
        }



        public List<Invoices> getInvoiceList(string direction)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                return dbContext.invoices.Where(inv => inv.direction == direction).OrderByDescending(inv => inv.cDate).ToList();
            }
        }



        public List<Invoices> getWaitResponseInvoiceList(string direction)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                return dbContext.invoices.Where(inv => inv.direction == direction && inv.status.Contains(nameof(EI.StatusType.SEND)) &&
            inv.status.Contains(nameof(EI.SubStatusType.WAIT_APPLICATION_RESPONSE))).OrderByDescending(inv => inv.cDate).ToList();
            }
        }



        public List<Invoices> getRejectedInvoiceList(string direction)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                return dbContext.invoices.Where(inv => inv.direction == direction && inv.status.Contains(nameof(EI.StatusType.REJECTED))
            && inv.status.Contains(nameof(EI.SubStatusType.SUCCEED))).OrderByDescending(inv => inv.cDate).ToList();
            }
        }



        public List<Invoices> getInvoiceListOnFilter(string direction,DateTime startTime,DateTime finishTime)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                return dbContext.invoices.Where(inv => inv.direction == direction
            && inv.cDate <= finishTime
            && inv.cDate >= startTime).OrderByDescending(inv => inv.cDate).ToList();
            }
        }


      



        public bool updateInvState(string direction, GetInvoiceStatusResponseINVOICE_STATUS invStatusResponse)
        {
            using (DatabaseContext dbContext=new DatabaseContext())
            {
                var invoice = dbContext.invoices.Where(inv => inv.direction == direction
            && inv.uuid == invStatusResponse.UUID).First();

                invoice.status = invStatusResponse.STATUS;
                invoice.cDate = invStatusResponse.CDATE;
                invoice.envelopeIdentifier = invStatusResponse.ENVELOPE_IDENTIFIER;
                invoice.gibStatusCode = invStatusResponse.GIB_STATUS_CODE;
                invoice.gibStatusDescription = invStatusResponse.GIB_STATUS_DESCRIPTION;

                if (dbContext.SaveChanges().Equals(1))
                {
                    return true;
                }
                return false;
            }
          
        }




        public void addInvoice(Invoices inv)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                dbContext.invoices.Add(inv);
                dbContext.SaveChanges();
            }
        }


        public void deleteInvoices(string uuid, string direction)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                Invoices invoice = dbContext.invoices.Where(inv => inv.direction == direction
            && inv.uuid == uuid).First();

                dbContext.invoices.Remove(invoice);
                dbContext.SaveChanges();
            }
        }

     
        public void updateInvIdDirectionStateNote(string uuid, string direction, string newId,string newDirection,string newFolderPath,string newStateNote)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                Invoices invoice = dbContext.invoices.Where(inv => inv.direction == direction
            && inv.uuid == uuid).First();

                invoice.ID = newId;
                invoice.direction = newDirection;
                invoice.folderPath = newFolderPath;
                invoice.stateNote = newStateNote;

                dbContext.SaveChanges();
            }
        }

        public void updateInvIdCdateStatusGibCodeStateNote(string uuid, string direction, 
            string newId, DateTime newCdate,string newStatus,int newGibStatusCode, string newStateNote)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                Invoices invoice = dbContext.invoices.Where(inv => inv.direction == direction
            && inv.uuid == uuid).First();

                invoice.ID = newId;
                invoice.cDate = newCdate;
                invoice.status = newStatus;
                invoice.gibStatusCode = newGibStatusCode;
                invoice.stateNote = newStateNote;

                dbContext.SaveChanges();
            }
        }



        public void insertDraftInvoice(InvoiceType invoiceUbl, string xmlPath)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                Invoices draftCreatedInv = new Invoices();

                draftCreatedInv.ID = invoiceUbl.ID.Value;
                draftCreatedInv.uuid = invoiceUbl.UUID.Value;
                draftCreatedInv.direction = EI.Direction.DRAFT.ToString();
                draftCreatedInv.draftFlag = EI.ActiveOrPasive.N.ToString();  //load ınv yapmadıklarımız flag N
                draftCreatedInv.cDate = invoiceUbl.IssueDate.Value;
                draftCreatedInv.profileId = invoiceUbl.ProfileID.Value;
                draftCreatedInv.invoiceType = invoiceUbl.InvoiceTypeCode.Value;
                draftCreatedInv.suplier = invoiceUbl.AccountingSupplierParty.Party.PartyName.Name.Value;
                draftCreatedInv.receiverVkn = invoiceUbl.AccountingCustomerParty.Party.PartyIdentification.First().ID.Value;
                draftCreatedInv.senderVkn = invoiceUbl.AccountingSupplierParty.Party.PartyIdentification.First().ID.Value;  //sıfırıncı ındexde tc ya da vkn tutuluyor         
                draftCreatedInv.status = "";//simdilik bos deger atıyoruz load ınv yaparken guncellenecektır
                draftCreatedInv.stateNote = nameof(EI.StateNote.CREATED);
                draftCreatedInv.draftFlag = nameof(EI.ActiveOrPasive.N);//bizim olusturdugumuz fatura flag N
                draftCreatedInv.folderPath = xmlPath;

                dbContext.invoices.Add(draftCreatedInv);
                dbContext.SaveChanges();
            }
        }



    }
}
