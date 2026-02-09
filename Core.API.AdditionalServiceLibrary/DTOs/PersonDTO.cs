#nullable disable

namespace Core.API.AdditionalServiceLibrary
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
