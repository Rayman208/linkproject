using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Linker
{
    public partial class Form1 : Form
    {
        #region LinkApi

        List<Address> addresses = null;

        private void AddLink(Address address)
        {
            dataGridViewLinks.Rows.Add
                    (
                    address.Id,
                    address.Name,
                    address.Url,
                    address.Description
                    );
        }

        private void ShowAllLinks()
        {
            dataGridViewLinks.Rows.Clear();
            foreach (Address address in addresses)
            {
                AddLink(address);
            }
        }

        private void DeleteChoosenLink()
        {
            if (dataGridViewLinks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ощитка виьбора");
                return;
            }
            string id = dataGridViewLinks.SelectedRows[0].Cells[0].Value.ToString();

            LinkApi.AddressesDeleteById(id);

            addresses = LinkApi.AddressesSelectAll();
            ShowAllLinks();

            ClearLinkInputs();
        }

        private void SearchAddresses()
        {
            string searchText = textBoxSearchText.Text;
            dataGridViewLinks.Rows.Clear();
            foreach (Address address in addresses)
            {
                if (checkBoxName.Checked == true)
                {
                    if (address.Name.ToLower().Contains(searchText.ToLower()) == true)
                    {
                        AddLink(address);
                    }
                }
                if (checkBoxUrl.Checked == true)
                {
                    if (address.Url.ToLower().Contains(searchText.ToLower()) == true)
                    {
                        AddLink(address);
                    }
                }
                if (checkBoxDescription.Checked == true)
                {
                    if (address.Description.ToLower().Contains(searchText.ToLower()) == true)
                    {
                        AddLink(address);
                    }
                }
            }
        }

        private void ClearLinkInputs()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxUrl.Clear();
            textBoxDescription.Clear();
        }

        private void AddNewLink()
        {
            Address tempLink = new Address()
            {
                Id=0,
                Name = textBoxName.Text,
                Url = textBoxUrl.Text,
                Description = textBoxDescription.Text
            };
            LinkApi.AddressesInsertNew(tempLink);

            ClearLinkInputs();

            addresses = LinkApi.AddressesSelectAll();
            ShowAllLinks();
        }

        private void FillLinkInputs()
        {
            if (dataGridViewLinks.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dataGridViewLinks.SelectedRows[0];

            textBoxId.Text = selectedRow.Cells[0].Value.ToString();
            textBoxName.Text = selectedRow.Cells[1].Value.ToString();
            textBoxUrl.Text = selectedRow.Cells[2].Value.ToString();
            textBoxDescription.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void UpdateLink()
        {
            Address tempLink = new Address()
            {
                Id = int.Parse(textBoxId.Text),
                Name = textBoxName.Text,
                Url = textBoxUrl.Text,
                Description = textBoxDescription.Text
            };
            LinkApi.AddressesUpdateById(tempLink);

            ClearLinkInputs();

            addresses = LinkApi.AddressesSelectAll();
            ShowAllLinks();
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAllLinks_Click(object sender, EventArgs e)
        {
            addresses = LinkApi.AddressesSelectAll();

            ShowAllLinks();
        }

        private void buttonDeleteChoosenLink_Click(object sender, EventArgs e)
        {
            DeleteChoosenLink();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ShowAllLinks();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchAddresses();
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            AddNewLink();
        }

        private void buttonClearInputs_Click(object sender, EventArgs e)
        {
            ClearLinkInputs();
        }

        private void dataGridViewLinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillLinkInputs();
        }

        private void buttoUpdateLink_Click(object sender, EventArgs e)
        {
            UpdateLink();
        }
    }
}
