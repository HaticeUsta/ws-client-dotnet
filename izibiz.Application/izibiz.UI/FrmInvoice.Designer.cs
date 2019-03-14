﻿namespace izibiz.UI
{
    partial class FrmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInvoice = new System.Windows.Forms.MenuStrip();
            this.itemIncomingInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemComingListInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSentInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSentInvoiceList = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDraftInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDraftInvoiceList = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDraftNewInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelConfirmation = new System.Windows.Forms.Panel();
            this.btnIncomingInvGetState = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnGetInvoiceIncoming = new System.Windows.Forms.Button();
            this.panelIncomingInvoice = new System.Windows.Forms.Panel();
            this.panelSentInvoice = new System.Windows.Forms.Panel();
            this.panelConfirmationSentInv = new System.Windows.Forms.Panel();
            this.btnFaultyInvoices = new System.Windows.Forms.Button();
            this.btnSentInvAgainSent = new System.Windows.Forms.Button();
            this.btnSentInvGetState = new System.Windows.Forms.Button();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.menuInvoice.SuspendLayout();
            this.panelConfirmation.SuspendLayout();
            this.panelIncomingInvoice.SuspendLayout();
            this.panelSentInvoice.SuspendLayout();
            this.panelConfirmationSentInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuInvoice
            // 
            this.menuInvoice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuInvoice.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemIncomingInvoice,
            this.itemSentInvoice,
            this.itemDraftInvoice});
            this.menuInvoice.Location = new System.Drawing.Point(0, 0);
            this.menuInvoice.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.menuInvoice.Name = "menuInvoice";
            this.menuInvoice.Size = new System.Drawing.Size(138, 566);
            this.menuInvoice.TabIndex = 0;
            this.menuInvoice.Text = "menuStrip1";
            // 
            // itemIncomingInvoice
            // 
            this.itemIncomingInvoice.BackColor = System.Drawing.Color.Teal;
            this.itemIncomingInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemComingListInvoice});
            this.itemIncomingInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemIncomingInvoice.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.itemIncomingInvoice.Name = "itemIncomingInvoice";
            this.itemIncomingInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemIncomingInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemIncomingInvoice.Text = "Gelen Faturalar";
            // 
            // itemComingListInvoice
            // 
            this.itemComingListInvoice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.itemComingListInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemComingListInvoice.Name = "itemComingListInvoice";
            this.itemComingListInvoice.Size = new System.Drawing.Size(186, 24);
            this.itemComingListInvoice.Text = "E-Fatura Listele";
            this.itemComingListInvoice.Click += new System.EventHandler(this.itemComingListInvoice_Click);
            // 
            // itemSentInvoice
            // 
            this.itemSentInvoice.BackColor = System.Drawing.Color.Teal;
            this.itemSentInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSentInvoiceList});
            this.itemSentInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemSentInvoice.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.itemSentInvoice.Name = "itemSentInvoice";
            this.itemSentInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemSentInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemSentInvoice.Text = " Giden Faturalar";
            // 
            // itemSentInvoiceList
            // 
            this.itemSentInvoiceList.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.itemSentInvoiceList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemSentInvoiceList.Name = "itemSentInvoiceList";
            this.itemSentInvoiceList.Size = new System.Drawing.Size(186, 24);
            this.itemSentInvoiceList.Text = "E-Fatura Listele";
            this.itemSentInvoiceList.Click += new System.EventHandler(this.itemSentInvoiceList_Click);
            // 
            // itemDraftInvoice
            // 
            this.itemDraftInvoice.BackColor = System.Drawing.Color.Teal;
            this.itemDraftInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDraftInvoiceList,
            this.itemDraftNewInvoice});
            this.itemDraftInvoice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.itemDraftInvoice.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.itemDraftInvoice.Name = "itemDraftInvoice";
            this.itemDraftInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.itemDraftInvoice.Size = new System.Drawing.Size(131, 29);
            this.itemDraftInvoice.Text = "Taslak Faturalar";
            // 
            // itemDraftInvoiceList
            // 
            this.itemDraftInvoiceList.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.itemDraftInvoiceList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemDraftInvoiceList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.itemDraftInvoiceList.Name = "itemDraftInvoiceList";
            this.itemDraftInvoiceList.Size = new System.Drawing.Size(219, 24);
            this.itemDraftInvoiceList.Text = "Taslak Fatura Listele";
            this.itemDraftInvoiceList.Click += new System.EventHandler(this.itemDraftInvoiceList_Click);
            // 
            // itemDraftNewInvoice
            // 
            this.itemDraftNewInvoice.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.itemDraftNewInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemDraftNewInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.itemDraftNewInvoice.Name = "itemDraftNewInvoice";
            this.itemDraftNewInvoice.Size = new System.Drawing.Size(219, 24);
            this.itemDraftNewInvoice.Text = "+Yeni Fatura";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(543, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "kkm";
            // 
            // panelConfirmation
            // 
            this.panelConfirmation.Controls.Add(this.btnIncomingInvGetState);
            this.panelConfirmation.Controls.Add(this.btnAccept);
            this.panelConfirmation.Controls.Add(this.btnReject);
            this.panelConfirmation.Controls.Add(this.btnGetInvoiceIncoming);
            this.panelConfirmation.Location = new System.Drawing.Point(17, 8);
            this.panelConfirmation.Name = "panelConfirmation";
            this.panelConfirmation.Size = new System.Drawing.Size(768, 72);
            this.panelConfirmation.TabIndex = 14;
            this.panelConfirmation.Visible = false;
            // 
            // btnIncomingInvGetState
            // 
            this.btnIncomingInvGetState.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIncomingInvGetState.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnIncomingInvGetState.FlatAppearance.BorderSize = 2;
            this.btnIncomingInvGetState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomingInvGetState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncomingInvGetState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncomingInvGetState.Location = new System.Drawing.Point(354, 19);
            this.btnIncomingInvGetState.Name = "btnIncomingInvGetState";
            this.btnIncomingInvGetState.Size = new System.Drawing.Size(120, 35);
            this.btnIncomingInvGetState.TabIndex = 3;
            this.btnIncomingInvGetState.Text = "durum sorgula";
            this.btnIncomingInvGetState.UseVisualStyleBackColor = false;
            this.btnIncomingInvGetState.Click += new System.EventHandler(this.btnIncomingInvGetState_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAccept.FlatAppearance.BorderSize = 2;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccept.Location = new System.Drawing.Point(5, 20);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(93, 35);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "kabul et";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.IndianRed;
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnReject.FlatAppearance.BorderSize = 2;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReject.Location = new System.Drawing.Point(117, 20);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(93, 35);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Reddet";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnGetInvoiceIncoming
            // 
            this.btnGetInvoiceIncoming.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGetInvoiceIncoming.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnGetInvoiceIncoming.FlatAppearance.BorderSize = 2;
            this.btnGetInvoiceIncoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInvoiceIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetInvoiceIncoming.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetInvoiceIncoming.Location = new System.Drawing.Point(228, 20);
            this.btnGetInvoiceIncoming.Name = "btnGetInvoiceIncoming";
            this.btnGetInvoiceIncoming.Size = new System.Drawing.Size(120, 35);
            this.btnGetInvoiceIncoming.TabIndex = 2;
            this.btnGetInvoiceIncoming.Text = "fatura al";
            this.btnGetInvoiceIncoming.UseVisualStyleBackColor = false;
            this.btnGetInvoiceIncoming.Click += new System.EventHandler(this.btnGetInvoiceIncoming_Click);
            // 
            // panelIncomingInvoice
            // 
            this.panelIncomingInvoice.Controls.Add(this.panelConfirmation);
            this.panelIncomingInvoice.Location = new System.Drawing.Point(204, 128);
            this.panelIncomingInvoice.Name = "panelIncomingInvoice";
            this.panelIncomingInvoice.Size = new System.Drawing.Size(854, 83);
            this.panelIncomingInvoice.TabIndex = 16;
            this.panelIncomingInvoice.Visible = false;
            // 
            // panelSentInvoice
            // 
            this.panelSentInvoice.Controls.Add(this.panelConfirmationSentInv);
            this.panelSentInvoice.Location = new System.Drawing.Point(204, 28);
            this.panelSentInvoice.Name = "panelSentInvoice";
            this.panelSentInvoice.Size = new System.Drawing.Size(850, 83);
            this.panelSentInvoice.TabIndex = 17;
            this.panelSentInvoice.Visible = false;
            // 
            // panelConfirmationSentInv
            // 
            this.panelConfirmationSentInv.Controls.Add(this.btnFaultyInvoices);
            this.panelConfirmationSentInv.Controls.Add(this.btnSentInvAgainSent);
            this.panelConfirmationSentInv.Controls.Add(this.btnSentInvGetState);
            this.panelConfirmationSentInv.Location = new System.Drawing.Point(17, 21);
            this.panelConfirmationSentInv.Name = "panelConfirmationSentInv";
            this.panelConfirmationSentInv.Size = new System.Drawing.Size(745, 47);
            this.panelConfirmationSentInv.TabIndex = 18;
            this.panelConfirmationSentInv.Visible = false;
            // 
            // btnFaultyInvoices
            // 
            this.btnFaultyInvoices.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFaultyInvoices.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnFaultyInvoices.FlatAppearance.BorderSize = 2;
            this.btnFaultyInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaultyInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaultyInvoices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFaultyInvoices.Location = new System.Drawing.Point(305, 8);
            this.btnFaultyInvoices.Name = "btnFaultyInvoices";
            this.btnFaultyInvoices.Size = new System.Drawing.Size(120, 35);
            this.btnFaultyInvoices.TabIndex = 18;
            this.btnFaultyInvoices.Text = "Hatalılar";
            this.btnFaultyInvoices.UseVisualStyleBackColor = false;
            // 
            // btnSentInvAgainSent
            // 
            this.btnSentInvAgainSent.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSentInvAgainSent.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSentInvAgainSent.FlatAppearance.BorderSize = 2;
            this.btnSentInvAgainSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentInvAgainSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSentInvAgainSent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSentInvAgainSent.Location = new System.Drawing.Point(158, 9);
            this.btnSentInvAgainSent.Name = "btnSentInvAgainSent";
            this.btnSentInvAgainSent.Size = new System.Drawing.Size(120, 35);
            this.btnSentInvAgainSent.TabIndex = 17;
            this.btnSentInvAgainSent.Text = "Yeniden gönder";
            this.btnSentInvAgainSent.UseVisualStyleBackColor = false;
            this.btnSentInvAgainSent.Click += new System.EventHandler(this.btnSentInvAgainSent_Click);
            // 
            // btnSentInvGetState
            // 
            this.btnSentInvGetState.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSentInvGetState.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnSentInvGetState.FlatAppearance.BorderSize = 2;
            this.btnSentInvGetState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentInvGetState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSentInvGetState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSentInvGetState.Location = new System.Drawing.Point(17, 9);
            this.btnSentInvGetState.Name = "btnSentInvGetState";
            this.btnSentInvGetState.Size = new System.Drawing.Size(120, 35);
            this.btnSentInvGetState.TabIndex = 16;
            this.btnSentInvGetState.Text = "Durum sorgula";
            this.btnSentInvGetState.UseVisualStyleBackColor = false;
            this.btnSentInvGetState.Click += new System.EventHandler(this.btnSentInvGetState_Click);
            // 
            // tableGrid
            // 
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrid.Location = new System.Drawing.Point(204, 268);
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.Size = new System.Drawing.Size(854, 286);
            this.tableGrid.TabIndex = 18;
            this.tableGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableGrid_CellClick);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1136, 566);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.panelIncomingInvoice);
            this.Controls.Add(this.panelSentInvoice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuInvoice);
            this.MainMenuStrip = this.menuInvoice;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.menuInvoice.ResumeLayout(false);
            this.menuInvoice.PerformLayout();
            this.panelConfirmation.ResumeLayout(false);
            this.panelIncomingInvoice.ResumeLayout(false);
            this.panelSentInvoice.ResumeLayout(false);
            this.panelConfirmationSentInv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemIncomingInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemSentInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemDraftInvoice;
        private System.Windows.Forms.ToolStripMenuItem itemComingListInvoice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem itemSentInvoiceList;
        private System.Windows.Forms.ToolStripMenuItem itemDraftInvoiceList;
        private System.Windows.Forms.Panel panelConfirmation;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnGetInvoiceIncoming;
        private System.Windows.Forms.Button btnIncomingInvGetState;
        private System.Windows.Forms.Panel panelIncomingInvoice;
        private System.Windows.Forms.Panel panelSentInvoice;
        private System.Windows.Forms.Button btnSentInvAgainSent;
        private System.Windows.Forms.Button btnSentInvGetState;
        private System.Windows.Forms.Panel panelConfirmationSentInv;
        private System.Windows.Forms.Button btnFaultyInvoices;
        private System.Windows.Forms.ToolStripMenuItem itemDraftNewInvoice;
        private System.Windows.Forms.DataGridView tableGrid;
    }
}