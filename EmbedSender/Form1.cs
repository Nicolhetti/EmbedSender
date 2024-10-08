﻿using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace EmbedSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var webhookUrl = txtWebhookUrl.Text;
            var messageContent = txtMessage.Text;  // Nuevo campo de mensaje
            var embedTitle = txtTitle.Text;
            var embedDescription = rtxtDescription.Text;
            var embedColor = txtColor.Text;
            var embedFooter = txtFooter.Text;
            var embedImage = txtImage.Text;
            var embedThumbnail = txtThumbnail.Text;
            var embedAuthorName = txtAuthorName.Text;
            var embedAuthorUrl = txtAuthorUrl.Text;
            var embedAuthorIcon = txtAuthorIcon.Text;
            var embedFields = rtxtFields.Text;

            int color;
            try
            {
                if (embedColor.StartsWith("#"))
                {
                    color = int.Parse(embedColor.Substring(1), System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    color = int.Parse(embedColor, System.Globalization.NumberStyles.HexNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El formato del color es incorrecto. Asegúrate de usar un formato hexadecimal válido (por ejemplo, #00ff00). Error: {ex.Message}", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var embed = new
            {
                title = embedTitle,
                description = embedDescription,
                color = color,
                timestamp = DateTime.UtcNow.ToString("o"),
                footer = new { text = embedFooter },
                image = new { url = embedImage },
                thumbnail = new { url = embedThumbnail },
                author = new { name = embedAuthorName, url = embedAuthorUrl, icon_url = embedAuthorIcon },
                fields = ParseFields(embedFields)
            };

            var data = new
            {
                content = messageContent,  // Añadir el mensaje al payload
                embeds = new[] { embed }
            };

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JObject.FromObject(data).ToString(), System.Text.Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(webhookUrl, content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Mensaje y embed enviados a Discord con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El mensaje y embed no se pudieron enviar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "config.json"; // Nombre predeterminado

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var config = new
                    {
                        webhookUrl = txtWebhookUrl.Text,
                        messageContent = txtMessage.Text,
                        embedTitle = txtTitle.Text,
                        embedDescription = rtxtDescription.Text,
                        embedColor = txtColor.Text,
                        embedFooter = txtFooter.Text,
                        embedImage = txtImage.Text,
                        embedThumbnail = txtThumbnail.Text,
                        embedAuthorName = txtAuthorName.Text,
                        embedAuthorUrl = txtAuthorUrl.Text,
                        embedAuthorIcon = txtAuthorIcon.Text,
                        embedFields = rtxtFields.Text
                    };

                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, JObject.FromObject(config).ToString());
                        MessageBox.Show("Configuración guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo guardar la configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var config = JObject.Parse(File.ReadAllText(openFileDialog.FileName));

                        txtWebhookUrl.Text = config["webhookUrl"]?.ToString();
                        txtMessage.Text = config["messageContent"]?.ToString();
                        txtTitle.Text = config["embedTitle"]?.ToString();
                        rtxtDescription.Text = config["embedDescription"]?.ToString();
                        txtColor.Text = config["embedColor"]?.ToString();
                        txtFooter.Text = config["embedFooter"]?.ToString();
                        txtImage.Text = config["embedImage"]?.ToString();
                        txtThumbnail.Text = config["embedThumbnail"]?.ToString();
                        txtAuthorName.Text = config["embedAuthorName"]?.ToString();
                        txtAuthorUrl.Text = config["embedAuthorUrl"]?.ToString();
                        txtAuthorIcon.Text = config["embedAuthorIcon"]?.ToString();
                        rtxtFields.Text = config["embedFields"]?.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo cargar la configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private object[] ParseFields(string fieldsText)
        {
            var fields = fieldsText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var fieldObjects = new object[fields.Length / 2];

            for (int i = 0; i < fields.Length; i += 2)
            {
                var name = fields[i];
                var value = fields[i + 1];
                fieldObjects[i / 2] = new { name, value, inline = false };
            }

            return fieldObjects;
        }
    }
}
