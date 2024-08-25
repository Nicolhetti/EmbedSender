namespace EmbedSender
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtMessage;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.lblWebhookUrl = new System.Windows.Forms.Label();
            this.txtWebhookUrl = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.txtFooter = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.txtThumbnail = new System.Windows.Forms.TextBox();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorUrl = new System.Windows.Forms.Label();
            this.txtAuthorUrl = new System.Windows.Forms.TextBox();
            this.lblAuthorIcon = new System.Windows.Forms.Label();
            this.txtAuthorIcon = new System.Windows.Forms.TextBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.rtxtFields = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBasic);
            this.tabControl.Controls.Add(this.tabAdvanced);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 510);
            this.tabControl.TabIndex = 0;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.label1);
            this.tabBasic.Controls.Add(this.txtMessage);
            this.tabBasic.Controls.Add(this.lblWebhookUrl);
            this.tabBasic.Controls.Add(this.txtWebhookUrl);
            this.tabBasic.Controls.Add(this.lblTitle);
            this.tabBasic.Controls.Add(this.txtTitle);
            this.tabBasic.Controls.Add(this.lblDescription);
            this.tabBasic.Controls.Add(this.rtxtDescription);
            this.tabBasic.Controls.Add(this.lblColor);
            this.tabBasic.Controls.Add(this.txtColor);
            this.tabBasic.Controls.Add(this.lblFooter);
            this.tabBasic.Controls.Add(this.txtFooter);
            this.tabBasic.Controls.Add(this.lblImage);
            this.tabBasic.Controls.Add(this.txtImage);
            this.tabBasic.Controls.Add(this.lblThumbnail);
            this.tabBasic.Controls.Add(this.txtThumbnail);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(452, 484);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Básico";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // lblWebhookUrl
            // 
            this.lblWebhookUrl.AutoSize = true;
            this.lblWebhookUrl.Location = new System.Drawing.Point(9, 18);
            this.lblWebhookUrl.Name = "lblWebhookUrl";
            this.lblWebhookUrl.Size = new System.Drawing.Size(99, 13);
            this.lblWebhookUrl.TabIndex = 0;
            this.lblWebhookUrl.Text = "URL del Webhook:";
            // 
            // txtWebhookUrl
            // 
            this.txtWebhookUrl.Location = new System.Drawing.Point(12, 34);
            this.txtWebhookUrl.Name = "txtWebhookUrl";
            this.txtWebhookUrl.Size = new System.Drawing.Size(430, 20);
            this.txtWebhookUrl.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 140);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Título:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 156);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(430, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 183);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descripción:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(12, 199);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(430, 96);
            this.rtxtDescription.TabIndex = 3;
            this.rtxtDescription.Text = "";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(9, 299);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(65, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color (HEX):";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(12, 315);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 4;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(9, 342);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(40, 13);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Footer:";
            // 
            // txtFooter
            // 
            this.txtFooter.Location = new System.Drawing.Point(12, 358);
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.Size = new System.Drawing.Size(430, 20);
            this.txtFooter.TabIndex = 5;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(9, 385);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(45, 13);
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "Imagen:";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(12, 401);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(430, 20);
            this.txtImage.TabIndex = 6;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(9, 428);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(53, 13);
            this.lblThumbnail.TabIndex = 6;
            this.lblThumbnail.Text = "Miniatura:";
            // 
            // txtThumbnail
            // 
            this.txtThumbnail.Location = new System.Drawing.Point(12, 444);
            this.txtThumbnail.Name = "txtThumbnail";
            this.txtThumbnail.Size = new System.Drawing.Size(430, 20);
            this.txtThumbnail.TabIndex = 7;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.lblAuthorName);
            this.tabAdvanced.Controls.Add(this.txtAuthorName);
            this.tabAdvanced.Controls.Add(this.lblAuthorUrl);
            this.tabAdvanced.Controls.Add(this.txtAuthorUrl);
            this.tabAdvanced.Controls.Add(this.lblAuthorIcon);
            this.tabAdvanced.Controls.Add(this.txtAuthorIcon);
            this.tabAdvanced.Controls.Add(this.lblFields);
            this.tabAdvanced.Controls.Add(this.rtxtFields);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(452, 404);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Avanzado";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(9, 20);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(92, 13);
            this.lblAuthorName.TabIndex = 7;
            this.lblAuthorName.Text = "Nombre del Autor:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(12, 36);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(430, 20);
            this.txtAuthorName.TabIndex = 1;
            // 
            // lblAuthorUrl
            // 
            this.lblAuthorUrl.AutoSize = true;
            this.lblAuthorUrl.Location = new System.Drawing.Point(9, 63);
            this.lblAuthorUrl.Name = "lblAuthorUrl";
            this.lblAuthorUrl.Size = new System.Drawing.Size(77, 13);
            this.lblAuthorUrl.TabIndex = 8;
            this.lblAuthorUrl.Text = "URL del Autor:";
            // 
            // txtAuthorUrl
            // 
            this.txtAuthorUrl.Location = new System.Drawing.Point(12, 79);
            this.txtAuthorUrl.Name = "txtAuthorUrl";
            this.txtAuthorUrl.Size = new System.Drawing.Size(430, 20);
            this.txtAuthorUrl.TabIndex = 2;
            // 
            // lblAuthorIcon
            // 
            this.lblAuthorIcon.AutoSize = true;
            this.lblAuthorIcon.Location = new System.Drawing.Point(9, 106);
            this.lblAuthorIcon.Name = "lblAuthorIcon";
            this.lblAuthorIcon.Size = new System.Drawing.Size(82, 13);
            this.lblAuthorIcon.TabIndex = 9;
            this.lblAuthorIcon.Text = "Icono del Autor:";
            // 
            // txtAuthorIcon
            // 
            this.txtAuthorIcon.Location = new System.Drawing.Point(12, 122);
            this.txtAuthorIcon.Name = "txtAuthorIcon";
            this.txtAuthorIcon.Size = new System.Drawing.Size(430, 20);
            this.txtAuthorIcon.TabIndex = 3;
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(9, 145);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(48, 13);
            this.lblFields.TabIndex = 10;
            this.lblFields.Text = "Campos:";
            // 
            // rtxtFields
            // 
            this.rtxtFields.Location = new System.Drawing.Point(12, 161);
            this.rtxtFields.Name = "rtxtFields";
            this.rtxtFields.Size = new System.Drawing.Size(430, 96);
            this.rtxtFields.TabIndex = 4;
            this.rtxtFields.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 78);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(430, 57);
            this.txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 528);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(397, 528);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mensaje:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Embed Sender - By Nicolhetti";
            this.tabControl.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tabBasic.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.TextBox txtWebhookUrl;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtFooter;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtThumbnail;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtAuthorUrl;
        private System.Windows.Forms.TextBox txtAuthorIcon;
        private System.Windows.Forms.RichTextBox rtxtFields;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblWebhookUrl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblAuthorUrl;
        private System.Windows.Forms.Label lblAuthorIcon;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.Label label1;
    }
}
