using Core1.Entities;

namespace WebAppUI.ViewModels;

public class HomeViewModel
{
    public IEnumerable<SlideItem> SlideItems { get; set; } = null!;
    public IEnumerable<ShippingItem> ShippingItems { get; set; } = null!;

}
