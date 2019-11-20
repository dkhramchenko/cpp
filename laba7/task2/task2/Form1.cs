using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // В поле currentFolderPath будет храниться путь к просматриваемой папке
        private string currentFolderPath;

        // очищает все поля
        private void ClearAllFields()
        {
            listBoxFolders.Items.Clear();
            listBoxFiles.Items.Clear();
            textBoxFolder.Text = "";
            textBoxFileName.Text = "";
            textBoxCreationTime.Text = "";
            textBoxFileSize.Text = "";
        }

        // отображает список папок
        private void DisplayFolderList(string folderFullName)
        {
            DirectoryInfo theFolder = new DirectoryInfo(folderFullName);
            if (!theFolder.Exists)
            {
                MessageBox.Show("Папка не найдена: " + folderFullName);
            }
            ClearAllFields();
            textBoxFolder.Text = theFolder.FullName;
            currentFolderPath = theFolder.FullName;
            
            foreach (DirectoryInfo nextFolder in theFolder.GetDirectories())
            {
                listBoxFolders.Items.Add(nextFolder.Name);
            }

            foreach (FileInfo nextFile in theFolder.GetFiles())
            {
                listBoxFiles.Items.Add(nextFile.Name);
            }
        }

        // Отображает файлы и папки, находящаяся внутри папки textBoxInput
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Введите путь к папке!");
                return;
            }
            string folderPath = textBoxInput.Text;
            DirectoryInfo theFolder = new DirectoryInfo(folderPath);
            if (theFolder.Exists)
            {
                DisplayFolderList(theFolder.FullName);
                return;
            }
            FileInfo theFile = new FileInfo(folderPath);
            if (theFile.Exists)
            {
                DisplayFolderList(theFile.Directory.FullName);
                int index = listBoxFiles.Items.IndexOf(theFile.Name);
                listBoxFiles.SetSelected(index, true);
                return;
            }
            MessageBox.Show("Нет файла или папки с именем: " + textBoxInput.Text);
        }

        // Отображает информацию о файле
        private void DisplayFileInfo(string fileFullName)
        {
            FileInfo theFile = new FileInfo(fileFullName);
            if (!theFile.Exists)
            {
                MessageBox.Show("Файл не найден: " + fileFullName);
            }
            textBoxFileName.Text = theFile.Name;
            textBoxCreationTime.Text = theFile.CreationTime.ToLongTimeString();
            textBoxFileSize.Text = theFile.Length + " bytes";
        }

        // Отображает подробности о выбранном файле
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = listBoxFiles.SelectedItem.ToString();
            string fullFileName = Path.Combine(currentFolderPath, selectedString);
            DisplayFileInfo(fullFileName);
        }

        // Меняет исследоваемую папку на выбранную из листбокса
        private void listBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedString = listBoxFolders.SelectedItem.ToString();
            string fullPathName = Path.Combine(currentFolderPath, selectedString);
            DisplayFolderList(fullPathName);
        }

        // Меняет исследоваемую папку на родительскую папку
        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (textBoxFolder.Text == "")
            {
                MessageBox.Show("Пусто!");
                return;
            }
            string folderPath = new FileInfo(currentFolderPath).DirectoryName;
            if (folderPath == null)
            {
                MessageBox.Show("Корневой каталог!");
                return;
            }
            DisplayFolderList(folderPath);
        }
    }
}
