#nullable disable

namespace Core.API.CQRS.AdditionalService
{
    //MODEL FOR CREATE INPUT
    public record BookDTO
    (
        string personId,

        string bookCategory,

        string bookName,

        string edition,

        string image,

        double price
    );
}
