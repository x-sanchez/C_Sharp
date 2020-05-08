﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeZhilin2020
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            firstnameTB.Text = "Имя";
            lastnameTB.Text = "Фамилия";
            emailTB.Text = "email";
            phoneTB.Text = "Телефон";
            LoginTB.Text = "Логин";
            PasswordTB.Text = "Пароль";
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (firstnameTB.Text == "" || firstnameTB.Text == "Имя")
                return;
            if (lastnameTB.Text == "" || lastnameTB.Text == "Фамилия")
                return;
            if (emailTB.Text == "" || emailTB.Text == "email")
                return;
            if (phoneTB.Text == "" || phoneTB.Text == "Телефон")
                return;
            if (LoginTB.Text == "" || LoginTB.Text == "Логин")
                return;
            if (PasswordTB.Text == "" || PasswordTB.Text == "Пароль")
                return;
            if (checkUser())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Login`, `First_name`, `Last_name`, `User_group`, `password`, `email`, `phone`, `Voices_player_id`, `Voices_coach_id`) VALUES (@login, @first_name, @last_name, 'user', @password, @email, @phone, NULL, NULL);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginTB.Text;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = firstnameTB.Text;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = lastnameTB.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTB.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTB.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneTB.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Succesful");
            else
                MessageBox.Show("Error");

            db.closeConnection();
        }
        public Boolean checkUser()
        {
            DB dB = new DB();

            DataTable datatable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l", dB.getConnection());

            command.Parameters.Add("@u_l", MySqlDbType.VarChar).Value = LoginTB.Text;


            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            if (datatable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Phone(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Телефон")
                (sender as TextBox).Text = "+7-___-___-__-__";
        }

        private void Def(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "+7-___-___-__-__" | (sender as TextBox).Text == "")
                (sender as TextBox).Text = "Телефон";
        }

        private void ClearN(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Имя")
                (sender as TextBox).Text = "";
            
        }

        private void ClearF(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Фамилия")
                (sender as TextBox).Text = "";
        }

        private void ClearE(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Email")
                (sender as TextBox).Text = "";
        }

        private void ClearL(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Логин")
                (sender as TextBox).Text = "";
        }

        private void Pass(object sender, MouseEventArgs e)
        {
            if ((sender as TextBox).Text == "Пароль")
                (sender as TextBox).Text = "";
            (sender as TextBox).UseSystemPasswordChar = true;
        }

        private void ClearP(object sender, MouseEventArgs e)
        {
            if((sender as TextBox).Text == "+7-___-___-__-__" )
                (sender as TextBox).Text = "";
        }
    }
}
