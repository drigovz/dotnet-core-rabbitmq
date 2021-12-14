namespace ProducerExemple.Application.Core.Books.Commands
{
    public class BookUpdateCommand : BookCommand
    {
        public int Id { get; set; }

        public BookUpdateCommand(int id)
        {
            Id = id;
        }
    }
}
