﻿using izibiz.CONTROLLER.Dal;
using izibiz.CONTROLLER.Web_Services;
using izibiz.MODEL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace izibiz.CONTROLLER.Singleton
{
   public class Singl
    {

        private static AuthenticationController instanceAuth = null;
        private static EInvoiceController instanceInvoice = null;
        private static DatabaseContext databaseContext = null;
        private static InvoiceDAL InvoiceDAL = null;


        private Singl()
        {      
        }

        public static InvoiceDAL invoiceDalGet
        {
            get
            {
                if (null == InvoiceDAL)
                {
                    InvoiceDAL = new InvoiceDAL();
                }

                return InvoiceDAL;
            }
        }

        public static DatabaseContext databaseContextGet
        {
            get
            {
                if (null == databaseContext)
                {
                    databaseContext = new DatabaseContext();
                }

                return databaseContext;
            }
        }


        public static AuthenticationController instanceAuthGet
        {
            get
            {
                if (null == instanceAuth)
                {
                    instanceAuth = new AuthenticationController();
                }

                return instanceAuth;
            }
        }

        public static EInvoiceController instanceInvoiceGet
        {
            get
            {
                if (null == instanceInvoice)
                {
                    instanceInvoice = new EInvoiceController();
                }

                return instanceInvoice;
            }
        }


    }
}