using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.Character
{
    // DTO : Data Transfer Object
    // an instance of a POCO (plain old CLR object) class used as a container to encapsulate data
    // and pass it from one layer of the application to another.
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10; 
        public RpgClass Class { get; set; } = RpgClass.Knight; 
         
    }
}