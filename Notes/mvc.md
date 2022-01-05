# The Model 
- Domain data + logic to manage data 
- Simple API
- Hides details of managing the data. 

## Sample Model Class

```cs
public class Pie 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public decimal Price { get; set; }
    public string ImageThumbnailUrl { get; set; }
    public bool IsPieOfTheWeek { get; set; }

}
```

# Repository 
- The repository allows our code to use objects without knowing how they are persisted. 

```cs
public interface IPieRepository 
{
    IEnumerable<Pie> GetAllPies();
    Pie GetPietById(int pieId);
}
```
## Pie Repository Interface 