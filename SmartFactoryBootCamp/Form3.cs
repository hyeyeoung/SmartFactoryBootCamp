using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Character;


namespace SmartFactoryBootCamp
{
    public partial class Form3 : Form
    {
        string FilePath = "";
        string fileContent = "";

        IDictionary<string, string> idPw = new Dictionary<string, string>(); // id, 비번
        IDictionary<string, string> idPhone = new Dictionary<string, string>(); // id, 전번
        public Form3()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                FilePath = file.FileName; // 파일 경로 가져오기
                var fileStream = file.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                // 파싱
                if(fileContent.Length > 0)
                {
                    string[] arr = fileContent.Split('\n');

                    for(int i = 0; i < arr.Length; i++)
                    {
                        string [] data = arr[i].Split(',');
                        idPw.Add(data[0], data[1]);

                        if (data.Length > 2)
                            idPhone.Add(data[0], data[2]);
                        else
                            idPhone.Add(data[0], null); // null 기입
                    }
                }

            }
        }
        // login
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(ID.Text.Length < 0 || PW.Text.Length < 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요");
            }
            else
            {
                if(idPw.Count > 0 && idPhone.Count > 0)
                {
                    if(idPw.TryGetValue(ID.Text, out string value))
                    {
                        if (idPw[ID.Text] == PW.Text)
                        {
                            if (idPhone[ID.Text] != null)
                            {
                                MessageBox.Show($"id: {ID.Text} \r\npw : {PW.Text} \r\nPhone : {idPhone[ID.Text]} ");
                            }
                            else
                            {
                                MessageBox.Show($"id: {ID.Text} \r\npw : {PW.Text}");
                            }
                        }
                    }
                    else
                    {
                        // 로그인 실패
                        MessageBox.Show("로그인 실패\r\n존재하지 않는 아이디입니다.");
                    }
                }
                else
                {
                    MessageBox.Show("계정 정보를 먼저 업로드해주세요");
                }
            }
        }
    }
}
