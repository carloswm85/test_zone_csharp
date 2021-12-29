// AUTOMAPPER REPLACEMENT
// When to use? Whereever you need to map (project) your DB entity into a DTO.
// ie. A data service layer. You don't get much value in 1:1 mappings so
// extension methods aren't my favorite here.
var dto = dbo.ToDto()
public class Dbo {}
public class Dto {}
public static class DboExtensions
{
  public static ToDto(this Dbo dbo)
  {
    return new Dbo
    {
       FieldA = dbo.FieldA;
       FieldB = dbo.FieldA;
       ComplexField = dbo.ComplexField.ToDto(); //repeat
    }
  }
}