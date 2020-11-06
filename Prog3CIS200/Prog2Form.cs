// Program 2
// CIS 200-01
// Due: 3/8/2020
// By: Andrew L. Wright (Students use Grading ID)

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.

// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace LibraryItems
{
    public partial class Prog2Form : Form
    {
        private BinaryFormatter reader = new BinaryFormatter();
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private Library _lib; // The library
        private FileStream input;

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 2{NL}By: Andrew L. Wright{NL}CIS 200-01{NL}Spring 2020",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons;     // List of patrons
            string NL = Environment.NewLine; // NewLine shortcut

            patrons = _lib.GetPatronsList();

            reportTxt.Text = $"Patron List - {patrons.Count} patrons{NL}{NL}";

            foreach (LibraryPatron p in patrons)
                reportTxt.AppendText($"{p}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            reportTxt.Text = $"Item List - {items.Count} items{NL}{NL}";

            foreach (LibraryItem item in items)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            reportTxt.Text = $"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}";

            foreach (LibraryItem item in checkedOutItems)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryPatron> patrons; // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();

            if (((items.Count - _lib.GetCheckedOutCount()) == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(items, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();

            if ((_lib.GetCheckedOutCount() == 0)) // Must have items to return
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(items); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.ReturnToShelf(returnForm.ItemIndex);
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("File Name invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    try
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        formatter.Serialize(output, _lib);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Unable to open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Error writting to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output?.Close();
                    }
                }
            }
        }


        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                reportTxt.Clear();

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        _lib = (Library)reader.Deserialize(input);
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Unable to open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        input?.Close();
                    }
                }
            }
        }

        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // List of library items
            List<LibraryPatron> patrons; // List of patrons

            patrons = _lib.GetPatronsList();

            if (patrons.Count() == 0) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                PatronEdit patronEdit = new PatronEdit(patrons); // The check out dialog box form

                DialogResult result = patronEdit.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        PatronForm patron1 = new PatronForm();
                        LibraryPatron selected = patrons[patronEdit.PatronIndex];

                        
                        patron1.PatronName = selected.PatronName;
                        patron1.PatronID = selected.PatronID;
                        patron1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            selected.PatronName = patron1.PatronName;
                            selected.PatronID = patron1.PatronID;
                        }
                    }
                    finally
                    {
                      patronEdit.Dispose(); // Good .NET practice - will get garbage collected anyway
  
                    }

                }

            }
        }
    }
}
