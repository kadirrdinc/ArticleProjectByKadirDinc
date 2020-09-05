namespace ArticleProject.Api.Models
{
    public class ReturnModel
    {
        public bool IsSuccess { get; set; }
        public string Redirect { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }

    public class ReturnModel<T>
    {
        public bool IsSuccess { get; set; }
        public string Redirect { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}