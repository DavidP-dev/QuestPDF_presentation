using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDFShowcase.InvoiceImplementation;

// You have to manually set the license type. It's not working without it
QuestPDF.Settings.License = LicenseType.Community;

// Create new InvoiceModel filled with intended data from your data source
var filledInvoiceModel = InvoiceDocumentDataSource.GetInvoiceDetails();

// Create new InvoiceDocument and fill it with InvoiceModel
var filledInvoiceDocument = new InvoiceDocument(filledInvoiceModel);

// Compose document
var composedInvoiceDocument = filledInvoiceDocument.Compose;

// Create document
var invoiceDocument = Document.Create(composedInvoiceDocument);

// Show your document in Previewer
invoiceDocument.ShowInPreviewer();

// Generate your document in PDF format
//invoiceDocument.GeneratePdf(@"C:\Users\dpic\Desktop\invoiceDocument.pdf");

// Generate your document in XPS format
//invoiceDocument.GenerateXps(@"C:\Users\dpic\Desktop\invoiceDocument.xps");