public class CategoryDetails
{
    public CategoryDetails()
    {
        Name = null;
        CanRelist = false;
        Promotions = Array.Empty<Promotion>();
    }

    public string? Name { get; set; }
    public bool CanRelist { get; set; }
    public Promotion[] Promotions { get; init; }
}