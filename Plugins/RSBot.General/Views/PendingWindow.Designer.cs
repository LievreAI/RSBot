namespace RSBot.General.Views
{
    partial class PendingWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingWindow));
            labelServerName = new SDUI.Label();
            labelNumberOfPeopleWaiting = new SDUI.Label();
            label1 = new SDUI.Label();
            labelPending = new SDUI.Label();
            labelAvgWaitingTime = new SDUI.Label();
            labelMyWaitingTime = new SDUI.Label();
            label5 = new SDUI.Label();
            buttonCancel = new SDUI.Button();
            buttonHide = new SDUI.Button();
            // 
            // labelServerName
            // 
            labelServerName.AutoSize = true;
            labelServerName.Location = new System.Drawing.Point(63, 10);
            labelServerName.Name = "labelServerName";
            labelServerName.Size = new System.Drawing.Size(286, 20);
            labelServerName.TabIndex = 0;
            labelServerName.Text = "{SERVER} is pending for server connection";
            // 
            // labelNumberOfPeopleWaiting
            // 
            labelNumberOfPeopleWaiting.AutoSize = true;
            labelNumberOfPeopleWaiting.Location = new System.Drawing.Point(79, 61);
            labelNumberOfPeopleWaiting.Name = "labelNumberOfPeopleWaiting";
            labelNumberOfPeopleWaiting.Size = new System.Drawing.Size(165, 17);
            labelNumberOfPeopleWaiting.TabIndex = 0;
            labelNumberOfPeopleWaiting.Text = "Number of people waiting:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 17);
            label1.TabIndex = 0;
            label1.Text = "Average waiting time: ";
            // 
            // labelPending
            // 
            labelPending.AutoSize = true;
            labelPending.Location = new System.Drawing.Point(259, 61);
            labelPending.Name = "labelPending";
            labelPending.Size = new System.Drawing.Size(0, 17);
            labelPending.TabIndex = 0;
            // 
            // labelAvgWaitingTime
            // 
            labelAvgWaitingTime.AutoSize = true;
            labelAvgWaitingTime.Location = new System.Drawing.Point(194, 112);
            labelAvgWaitingTime.Name = "labelAvgWaitingTime";
            labelAvgWaitingTime.Size = new System.Drawing.Size(15, 17);
            labelAvgWaitingTime.TabIndex = 0;
            labelAvgWaitingTime.Text = "0";
            // 
            // labelMyWaitingTime
            // 
            labelMyWaitingTime.AutoSize = true;
            labelMyWaitingTime.Location = new System.Drawing.Point(194, 147);
            labelMyWaitingTime.Name = "labelMyWaitingTime";
            labelMyWaitingTime.Size = new System.Drawing.Size(15, 17);
            labelMyWaitingTime.TabIndex = 0;
            labelMyWaitingTime.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(64, 147);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 17);
            label5.TabIndex = 0;
            label5.Text = "My waiting time:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(152, 207);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.ShadowDepth = 4F;
            buttonCancel.Size = new System.Drawing.Size(191, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel the waiting";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonHide
            // 
            buttonHide.Location = new System.Drawing.Point(70, 207);
            buttonHide.Name = "buttonHide";
            buttonHide.ShadowDepth = 4F;
            buttonHide.Size = new System.Drawing.Size(72, 23);
            buttonHide.TabIndex = 2;
            buttonHide.Text = "Hide";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // PendingWindow
            // 
            Size = new System.Drawing.Size(401, 240);
            Controls.Add(buttonHide);
            Controls.Add(buttonCancel);
            Controls.Add(label5);
            Controls.Add(labelMyWaitingTime);
            Controls.Add(label1);
            Controls.Add(labelAvgWaitingTime);
            Controls.Add(labelPending);
            Controls.Add(labelNumberOfPeopleWaiting);
            Controls.Add(labelServerName);
            MaximumSize = new System.Drawing.Size(401, 240);
            MinimumSize = new System.Drawing.Size(401, 240);
            Name = "PendingWindow";
        }

        #endregion

        private SDUI.Label labelServerName;
        private SDUI.Label labelNumberOfPeopleWaiting;
        private SDUI.Label label1;
        private SDUI.Label labelPending;
        private SDUI.Label labelAvgWaitingTime;
        private SDUI.Label labelMyWaitingTime;
        private SDUI.Label label5;
        private SDUI.Button buttonCancel;
        private SDUI.Button buttonHide;
    }
}