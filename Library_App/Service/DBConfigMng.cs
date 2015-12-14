using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_App.Models;
using System.IO;
using System.Windows.Forms;

namespace Library_App.Service
{
    class DbConfigMng
    {
        private static readonly string fileConfigPath = System.Environment.CurrentDirectory + @"\" + "db.config";
        public DbConfig ReadDbConfig() 
        {
            try
            {
                string[] configLines = File.ReadAllLines(fileConfigPath);
                DbConfig config = new DbConfig();
                for(int i=0; i<configLines.Length; i++)
                {
                    switch(i)
                    {
                        case 0:
                            config.ServerName = configLines[i].Trim();
                            break;
                        case 1:
                            if(configLines[i].Trim().ToLower() == "sql")
                            {
                                config.AuthType = DbAuthType.Sql;
                            }
                            else
                            {
                                config.AuthType = DbAuthType.Windows;
                                i = configLines.Length;
                            }
                            break;
                        case 2:
                            config.SqlLogin = configLines[i].Trim();
                            break;
                        case 3:
                            config.SqlPassword = configLines[i].Trim();
                            break;
                    }                    
                }
                return config;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения конфиг БД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
            
        }
    }
}
