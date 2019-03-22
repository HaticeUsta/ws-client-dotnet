﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izibiz.COMMON
{
   public partial class EI

    {
        
      

        public enum InvType
        {
            INCOMING,
            SENT,
            DRAFT
        }


        public enum Direction
        {
            IN,
            OUT
        }

        public enum InvoiceResponseStatus
        {
           RED,
           KABUL
        }

        public enum ActiveOrPasive
        {
          Y,
          N
        }

      

        public enum InvoiceProfileid
        {
           TEMELFATURA,
           TICARIFATURA
        }

    

        public enum InvoiceDownloadType
        {
           PDF,
           XML,
           HTML
        }

        public enum StatusType
        {
            RECEIVE,
            ACCEPT,
            REJECT,
            LOAD,
            PACKAGE,
            SEND,
            ACCEPTED,
            REJECTED,
            SIGN
        }

        public enum SubStatusType
        {
            SUCCEED,
            FAILED,
            PROCESSING,
            WAIT_GIB_RESPONSE,
            WAIT_SYSTEM_RESPONSE,
            WAIT_APPLICATION_RESPONSE
        }

        public enum InvTableName
        {
            Invoices
        }
        public enum InvClmName
        {
            ID,
            uuid,
            invType,
            issueDate,
            profileid,
            type,
            suplier,
            sender,
            cDate,
            envelopeIdentifier,
            status,
            statusDesc,
            gibStatusCode,
            gibStatusDescription,
            fromm,
            too
        }

        
    }
}