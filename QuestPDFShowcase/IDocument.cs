using QuestPDF.Infrastructure;

namespace QuestPDFShowcase;

public interface IDocument
{
    DocumentMetadata GetMetadata();
    DocumentSettings GetSettings();
    void Compose(IDocumentContainer container);
}