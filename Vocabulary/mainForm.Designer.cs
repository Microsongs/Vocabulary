namespace Vocabulary
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lang_ComboBox = new System.Windows.Forms.ComboBox();
            this.lang_Label = new System.Windows.Forms.Label();
            this.wordList_Label = new System.Windows.Forms.Label();
            this.wordList_dataGridView = new System.Windows.Forms.DataGridView();
            this.wordTotal_Label = new System.Windows.Forms.Label();
            this.add_Btn = new System.Windows.Forms.Button();
            this.del_Btn = new System.Windows.Forms.Button();
            this.save_Btn = new System.Windows.Forms.Button();
            this.load_Btn = new System.Windows.Forms.Button();
            this.testResult_Label = new System.Windows.Forms.Label();
            this.test_Btn = new System.Windows.Forms.Button();
            this.furigana_Label = new System.Windows.Forms.Label();
            this.state_Label = new System.Windows.Forms.Label();
            this.furigana_Btn = new System.Windows.Forms.Button();
            this.theme_Label = new System.Windows.Forms.Label();
            this.theme_ComboBox = new System.Windows.Forms.ComboBox();
            this.testResult_dataGridView = new System.Windows.Forms.DataGridView();
            this.resultReset_Btn = new System.Windows.Forms.Button();
            this.total_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResult_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lang_ComboBox
            // 
            this.lang_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lang_ComboBox.FormattingEnabled = true;
            this.lang_ComboBox.Location = new System.Drawing.Point(782, 73);
            this.lang_ComboBox.Name = "lang_ComboBox";
            this.lang_ComboBox.Size = new System.Drawing.Size(181, 33);
            this.lang_ComboBox.TabIndex = 0;
            this.lang_ComboBox.Text = "lang_Label";
            this.lang_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Lang_ComboBox_SelectedIndexChanged);
            // 
            // lang_Label
            // 
            this.lang_Label.AutoSize = true;
            this.lang_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lang_Label.Location = new System.Drawing.Point(773, 30);
            this.lang_Label.Name = "lang_Label";
            this.lang_Label.Size = new System.Drawing.Size(118, 26);
            this.lang_Label.TabIndex = 1;
            this.lang_Label.Text = "lang_Label";
            // 
            // wordList_Label
            // 
            this.wordList_Label.AutoSize = true;
            this.wordList_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordList_Label.Location = new System.Drawing.Point(19, 20);
            this.wordList_Label.Name = "wordList_Label";
            this.wordList_Label.Size = new System.Drawing.Size(158, 26);
            this.wordList_Label.TabIndex = 2;
            this.wordList_Label.Text = "wordList_Label";
            // 
            // wordList_dataGridView
            // 
            this.wordList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordList_dataGridView.Location = new System.Drawing.Point(24, 49);
            this.wordList_dataGridView.Name = "wordList_dataGridView";
            this.wordList_dataGridView.Size = new System.Drawing.Size(316, 322);
            this.wordList_dataGridView.TabIndex = 3;
            // 
            // wordTotal_Label
            // 
            this.wordTotal_Label.AutoSize = true;
            this.wordTotal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTotal_Label.Location = new System.Drawing.Point(183, 20);
            this.wordTotal_Label.Name = "wordTotal_Label";
            this.wordTotal_Label.Size = new System.Drawing.Size(171, 25);
            this.wordTotal_Label.TabIndex = 4;
            this.wordTotal_Label.Text = "wordTotal_Label";
            // 
            // add_Btn
            // 
            this.add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Btn.Location = new System.Drawing.Point(24, 377);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(153, 30);
            this.add_Btn.TabIndex = 5;
            this.add_Btn.Text = "add_Btn";
            this.add_Btn.UseVisualStyleBackColor = true;
            // 
            // del_Btn
            // 
            this.del_Btn.FlatAppearance.BorderSize = 0;
            this.del_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_Btn.Location = new System.Drawing.Point(183, 377);
            this.del_Btn.Name = "del_Btn";
            this.del_Btn.Size = new System.Drawing.Size(157, 30);
            this.del_Btn.TabIndex = 6;
            this.del_Btn.Text = "del_Btn";
            this.del_Btn.UseVisualStyleBackColor = true;
            // 
            // save_Btn
            // 
            this.save_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Btn.Location = new System.Drawing.Point(24, 413);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.Size = new System.Drawing.Size(153, 30);
            this.save_Btn.TabIndex = 7;
            this.save_Btn.Text = "save_Btn";
            this.save_Btn.UseVisualStyleBackColor = true;
            // 
            // load_Btn
            // 
            this.load_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_Btn.Location = new System.Drawing.Point(183, 413);
            this.load_Btn.Name = "load_Btn";
            this.load_Btn.Size = new System.Drawing.Size(157, 30);
            this.load_Btn.TabIndex = 8;
            this.load_Btn.Text = "load_Btn";
            this.load_Btn.UseVisualStyleBackColor = true;
            // 
            // testResult_Label
            // 
            this.testResult_Label.AutoSize = true;
            this.testResult_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testResult_Label.Location = new System.Drawing.Point(410, 219);
            this.testResult_Label.Name = "testResult_Label";
            this.testResult_Label.Size = new System.Drawing.Size(173, 25);
            this.testResult_Label.TabIndex = 9;
            this.testResult_Label.Text = "testResult_Label";
            // 
            // test_Btn
            // 
            this.test_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_Btn.Location = new System.Drawing.Point(415, 62);
            this.test_Btn.Name = "test_Btn";
            this.test_Btn.Size = new System.Drawing.Size(200, 100);
            this.test_Btn.TabIndex = 10;
            this.test_Btn.Text = "test_Btn";
            this.test_Btn.UseVisualStyleBackColor = true;
            // 
            // furigana_Label
            // 
            this.furigana_Label.AutoSize = true;
            this.furigana_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furigana_Label.Location = new System.Drawing.Point(773, 126);
            this.furigana_Label.Name = "furigana_Label";
            this.furigana_Label.Size = new System.Drawing.Size(155, 25);
            this.furigana_Label.TabIndex = 11;
            this.furigana_Label.Text = "furigana_Label";
            // 
            // state_Label
            // 
            this.state_Label.AutoSize = true;
            this.state_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_Label.Location = new System.Drawing.Point(773, 165);
            this.state_Label.Name = "state_Label";
            this.state_Label.Size = new System.Drawing.Size(124, 25);
            this.state_Label.TabIndex = 12;
            this.state_Label.Text = "state_Label";
            // 
            // furigana_Btn
            // 
            this.furigana_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furigana_Btn.Location = new System.Drawing.Point(903, 159);
            this.furigana_Btn.Name = "furigana_Btn";
            this.furigana_Btn.Size = new System.Drawing.Size(75, 37);
            this.furigana_Btn.TabIndex = 13;
            this.furigana_Btn.Text = "furigana_Btn";
            this.furigana_Btn.UseVisualStyleBackColor = true;
            // 
            // theme_Label
            // 
            this.theme_Label.AutoSize = true;
            this.theme_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme_Label.Location = new System.Drawing.Point(779, 219);
            this.theme_Label.Name = "theme_Label";
            this.theme_Label.Size = new System.Drawing.Size(136, 25);
            this.theme_Label.TabIndex = 14;
            this.theme_Label.Text = "theme_Label";
            // 
            // theme_ComboBox
            // 
            this.theme_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme_ComboBox.FormattingEnabled = true;
            this.theme_ComboBox.Location = new System.Drawing.Point(784, 247);
            this.theme_ComboBox.Name = "theme_ComboBox";
            this.theme_ComboBox.Size = new System.Drawing.Size(179, 33);
            this.theme_ComboBox.TabIndex = 15;
            this.theme_ComboBox.Text = "theme_Combobox";
            this.theme_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Theme_ComboBox_SelectedIndexChanged);
            // 
            // testResult_dataGridView
            // 
            this.testResult_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testResult_dataGridView.Location = new System.Drawing.Point(415, 247);
            this.testResult_dataGridView.Name = "testResult_dataGridView";
            this.testResult_dataGridView.Size = new System.Drawing.Size(240, 150);
            this.testResult_dataGridView.TabIndex = 16;
            // 
            // resultReset_Btn
            // 
            this.resultReset_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultReset_Btn.Location = new System.Drawing.Point(469, 403);
            this.resultReset_Btn.Name = "resultReset_Btn";
            this.resultReset_Btn.Size = new System.Drawing.Size(126, 39);
            this.resultReset_Btn.TabIndex = 17;
            this.resultReset_Btn.Text = "resultReset_Btn";
            this.resultReset_Btn.UseVisualStyleBackColor = true;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(298, 20);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(118, 25);
            this.total_Label.TabIndex = 18;
            this.total_Label.Text = "total_Label";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 454);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.resultReset_Btn);
            this.Controls.Add(this.testResult_dataGridView);
            this.Controls.Add(this.theme_ComboBox);
            this.Controls.Add(this.theme_Label);
            this.Controls.Add(this.furigana_Btn);
            this.Controls.Add(this.state_Label);
            this.Controls.Add(this.furigana_Label);
            this.Controls.Add(this.test_Btn);
            this.Controls.Add(this.testResult_Label);
            this.Controls.Add(this.load_Btn);
            this.Controls.Add(this.save_Btn);
            this.Controls.Add(this.del_Btn);
            this.Controls.Add(this.add_Btn);
            this.Controls.Add(this.wordTotal_Label);
            this.Controls.Add(this.wordList_dataGridView);
            this.Controls.Add(this.wordList_Label);
            this.Controls.Add(this.lang_Label);
            this.Controls.Add(this.lang_ComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResult_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lang_ComboBox;
        private System.Windows.Forms.Label lang_Label;
        private System.Windows.Forms.Label wordList_Label;
        private System.Windows.Forms.DataGridView wordList_dataGridView;
        private System.Windows.Forms.Label wordTotal_Label;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.Button del_Btn;
        private System.Windows.Forms.Button save_Btn;
        private System.Windows.Forms.Button load_Btn;
        private System.Windows.Forms.Label testResult_Label;
        private System.Windows.Forms.Button test_Btn;
        private System.Windows.Forms.Label furigana_Label;
        private System.Windows.Forms.Label state_Label;
        private System.Windows.Forms.Button furigana_Btn;
        private System.Windows.Forms.Label theme_Label;
        private System.Windows.Forms.ComboBox theme_ComboBox;
        private System.Windows.Forms.DataGridView testResult_dataGridView;
        private System.Windows.Forms.Button resultReset_Btn;
        private System.Windows.Forms.Label total_Label;
    }
}

