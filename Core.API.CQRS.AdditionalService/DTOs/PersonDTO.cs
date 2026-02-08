#nullable disable

namespace Core.API.CQRS.AdditionalService
{
    //MODEL FOR CREATE INPUT
    public record PersonDTO
   (
        string firstName,

        string lastName,

        int rank,

        string category,

        DateTime dateOfBirth,

        bool isPlayCricket
   );
}
