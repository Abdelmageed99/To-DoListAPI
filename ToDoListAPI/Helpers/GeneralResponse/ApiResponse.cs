namespace ToDoListAPI.Helpers.GeneralResponse
{
    public class ApiResponse<T> 
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        public ApiResponse(bool isSuccess, string message, T? data = default)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }


        public static ApiResponse<T> Success(string message, T data)
             => new ApiResponse<T>(true, message, data);
       

        public static ApiResponse<T> Failure(string message)
            => new ApiResponse<T>(false, message);
        


    }
}
