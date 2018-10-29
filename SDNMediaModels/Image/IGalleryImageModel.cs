namespace SDNMediaModels.Image
{
    public interface IGalleryImageModel
    {
        string _src { get; set; }
        string _title { get; set; }

        string ConvertJson();
    }
}