namespace ISCG6421Assignment1
{
    partial class ChallengeForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteArena = new System.Windows.Forms.Button();
            this.btnUpdateArena = new System.Windows.Forms.Button();
            this.btnAddArena = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnMarkFinished = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(633, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteArena
            // 
            this.btnDeleteArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArena.Location = new System.Drawing.Point(633, 374);
            this.btnDeleteArena.Name = "btnDeleteArena";
            this.btnDeleteArena.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteArena.TabIndex = 23;
            this.btnDeleteArena.Text = "Delete Arena";
            this.btnDeleteArena.UseVisualStyleBackColor = false;
            this.btnDeleteArena.Click += new System.EventHandler(this.btnDeleteArena_Click);
            // 
            // btnUpdateArena
            // 
            this.btnUpdateArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArena.Location = new System.Drawing.Point(487, 374);
            this.btnUpdateArena.Name = "btnUpdateArena";
            this.btnUpdateArena.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateArena.TabIndex = 22;
            this.btnUpdateArena.Text = "Update Arena";
            this.btnUpdateArena.UseVisualStyleBackColor = false;
            this.btnUpdateArena.Click += new System.EventHandler(this.btnUpdateArena_Click);
            // 
            // btnAddArena
            // 
            this.btnAddArena.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddArena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArena.Location = new System.Drawing.Point(346, 374);
            this.btnAddArena.Name = "btnAddArena";
            this.btnAddArena.Size = new System.Drawing.Size(102, 23);
            this.btnAddArena.TabIndex = 21;
            this.btnAddArena.Text = "Add Arena";
            this.btnAddArena.UseVisualStyleBackColor = false;
            this.btnAddArena.Click += new System.EventHandler(this.btnAddArena_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(188, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">>>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(60, 374);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 23);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<<<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnMarkFinished
            // 
            this.btnMarkFinished.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarkFinished.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkFinished.Location = new System.Drawing.Point(60, 415);
            this.btnMarkFinished.Name = "btnMarkFinished";
            this.btnMarkFinished.Size = new System.Drawing.Size(230, 23);
            this.btnMarkFinished.TabIndex = 25;
            this.btnMarkFinished.Text = "Mark Challenge as Finished";
            this.btnMarkFinished.UseVisualStyleBackColor = false;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarkCompleted.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkCompleted.Location = new System.Drawing.Point(346, 415);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(243, 23);
            this.btnMarkCompleted.TabIndex = 26;
            this.btnMarkCompleted.Text = "Mark Challenge as Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = false;
            // 
            // ChallengeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.btnMarkFinished);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteArena);
            this.Controls.Add(this.btnUpdateArena);
            this.Controls.Add(this.btnAddArena);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChallengeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Challenge Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteArena;
        private System.Windows.Forms.Button btnUpdateArena;
        private System.Windows.Forms.Button btnAddArena;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnMarkFinished;
        private System.Windows.Forms.Button btnMarkCompleted;
    }
}