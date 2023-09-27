//using INSERT_UPDATE_DELETE.DataAccess_Layer.Entities;
using INSERT_UPDATE_DELETE.DataAccess_Layer;
using INSERT_UPDATE_DELETE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace INSERT_UPDATE_DELETE.Entities.Presentation_Layer
{
    public partial class ManageCategory : Form
    {

        public ManageCategory()
        {
            InitializeComponent();
        }

        private void ManageCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        void UpdateGridView()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            ListofCategoriesdataGridView.DataSource = categoryDataAccess.GetCategories();
        }
        void ClearFields()
        {
            addCategoryNametextBox.Text = String.Empty;
            UpdateCatgoryIdtextBox.Text = String.Empty;
            UpadetCategoryNametextBox.Text = String.Empty;
            deleteCategoryIdtextBox.Text = String.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.CreateCategory(addCategoryNametextBox.Text))
            {
                MessageBox.Show("New category added");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            if (UpdateCatgoryIdtextBox.Text == "")
            {
                MessageBox.Show("please give category id");
            }
            else
            {
                
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                Category category = categoryDataAccess.GetCategoryById(Convert.ToInt32(UpdateCatgoryIdtextBox.Text));
                if(category == null)
                {
                    MessageBox.Show("Category is not available");
                    ClearFields();
                }
                else
                {
                    UpadetCategoryNametextBox.Text = category.CategoryName;
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.UpdateCategory(Convert.ToInt32(UpadetCategoryNametextBox.Text), UpadetCategoryNametextBox.Text))
            {
                MessageBox.Show("Category Update");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteCategoryIdtextBox.Text == "")
            {
                MessageBox.Show("please give category id");
            }
            else
            {

                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                Category category = categoryDataAccess.GetCategoryById(Convert.ToInt32(deleteCategoryIdtextBox.Text));
                if (category == null)
                {
                    MessageBox.Show("Category is not available");
                    ClearFields();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        categoryDataAccess = new CategoryDataAccess();
                        if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryIdtextBox.Text)))
                        {
                            MessageBox.Show("Category deleted");
                            UpdateGridView();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Error in deleting");
                        }
                    }
                }
            }
        }
    }
}
