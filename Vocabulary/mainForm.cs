using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class MainForm : Form
    {
        private int total = 0;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        // 초기화
        private void Init()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Lang_ComboBoxSetting();
            Theme_ComboBoxSetting();
            btnSetting();
            total_Label.Text = total.ToString();
        }
        private void Theme_ComboBoxSetting()
        {
            theme_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] theme = { "Light", "Dark" };
            theme_ComboBox.Items.AddRange(theme);
            theme_ComboBox.SelectedIndex = Theme.Light;
        }

        private void Lang_ComboBoxSetting()
        {
            lang_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string [] lang = {"English","한국어","日本語"};
            lang_ComboBox.Items.AddRange(lang);
            lang_ComboBox.SelectedIndex = Language.english;
        }

        // 언어 설정
        private void Lang_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang_Label.Text = "Language";
            switch (lang_ComboBox.SelectedIndex)
            {
                case Language.english:
                    //this.Font = new System.Drawing.Font("MS Gothic", 9);
                    this.Name = "Vocabulary";
                    this.Text = "Vocabulary";

                    wordList_Label.Text = "Word List";
                    wordTotal_Label.Text = "Total : ";
                    add_Btn.Text = "Add";
                    del_Btn.Text = "Delete";
                    save_Btn.Text = "Save";
                    load_Btn.Text = "Load";

                    test_Btn.Text = "Test Vocabulary";
                    testResult_Label.Text = "Test Result";
                    resultReset_Btn.Text = "Reset";

                    furigana_Label.Text = "Fugigana";
                    state_Label.Text = "State : ";
                    theme_Label.Text = "Theme";
                    break;

                case Language.korean:
                    //this.Font = new System.Drawing.Font("맑은 고딕", 9);
                    this.Name = "단어장";
                    this.Text = "단어장";

                    wordList_Label.Text = "단어 리스트";
                    wordTotal_Label.Text = "총 개수 : ";
                    add_Btn.Text = "추가";
                    del_Btn.Text = "삭제";
                    save_Btn.Text = "저장";
                    load_Btn.Text = "불러오기";

                    test_Btn.Text = "단어시험 시작";
                    testResult_Label.Text = "시험 결과";
                    resultReset_Btn.Text = "초기화";

                    furigana_Label.Text = "후리가나";
                    state_Label.Text = "상태 : ";
                    theme_Label.Text = "테마";

                    break;
                case Language.japanese:
                    //this.Font = new System.Drawing.Font("MS Mincho", 9);
                    this.Name = "単語帳";
                    this.Text = "単語帳";

                    wordList_Label.Text = "単語テスト";
                    wordTotal_Label.Text = "トタル : ";
                    add_Btn.Text = "追加";
                    del_Btn.Text = "除去";
                    save_Btn.Text = "セーブ";
                    load_Btn.Text = "ロード";

                    test_Btn.Text = "テストスタと";
                    testResult_Label.Text = "テスト結果";
                    resultReset_Btn.Text = "リセット";

                    furigana_Label.Text = "フリガナ";
                    state_Label.Text = "状態 : ";
                    theme_Label.Text = "テーマ";

                    break;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSetting()
        {
            add_Btn.TabStop = false;
            add_Btn.FlatStyle = FlatStyle.Flat;
            add_Btn.FlatAppearance.BorderSize = 0;

            del_Btn.TabStop = false;
            del_Btn.FlatStyle = FlatStyle.Flat;
            del_Btn.FlatAppearance.BorderSize = 0;

            save_Btn.TabStop = false;
            save_Btn.FlatStyle = FlatStyle.Flat;
            save_Btn.FlatAppearance.BorderSize = 0;

            load_Btn.TabStop = false;
            load_Btn.FlatStyle = FlatStyle.Flat;
            load_Btn.FlatAppearance.BorderSize = 0;

            test_Btn.TabStop = false;
            test_Btn.FlatStyle = FlatStyle.Flat;
            test_Btn.FlatAppearance.BorderSize = 0;

            resultReset_Btn.TabStop = false;
            resultReset_Btn.FlatStyle = FlatStyle.Flat;
            resultReset_Btn.FlatAppearance.BorderSize = 0;

            furigana_Btn.TabStop = false;
            furigana_Btn.FlatStyle = FlatStyle.Flat;
            furigana_Btn.FlatAppearance.BorderSize = 0;
        }

        private void Theme_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (theme_ComboBox.SelectedIndex)
            {
                case Theme.Light:
                    this.BackColor = Color.Azure;
                    this.ForeColor = Color.Black;

                    add_Btn.BackColor = Color.LightGray;
                    del_Btn.BackColor = Color.LightGray;
                    load_Btn.BackColor = Color.LightGray;
                    save_Btn.BackColor = Color.LightGray;
                    test_Btn.BackColor = Color.LightGray;
                    resultReset_Btn.BackColor = Color.LightGray;
                    furigana_Btn.BackColor = Color.LightGray;

                    break;
                case Theme.Dark:
                    this.BackColor = Color.Gray;
                    this.ForeColor = Color.White;

                    add_Btn.FlatAppearance.BorderColor = Color.Gray;
                    add_Btn.BackColor = Color.DarkGray;
                    del_Btn.BackColor = Color.DarkGray;
                    load_Btn.BackColor = Color.DarkGray;
                    save_Btn.BackColor = Color.DarkGray;
                    test_Btn.BackColor = Color.DarkGray;
                    resultReset_Btn.BackColor = Color.DarkGray;
                    furigana_Btn.BackColor = Color.DarkGray;
                    break;
            }
        }
    }
}
