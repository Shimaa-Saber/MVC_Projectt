using Microsoft.AspNetCore.SignalR;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;

namespace MVC_Projec2.Hubs
{
    public class CommentHub:Hub
    {
        private readonly CommentRepository _commentRepo;

        public CommentHub(CommentRepository commentRepo)
        {
            _commentRepo = commentRepo;
        }

        public async Task NewCommentArrived(string userName, string commentText, int modelId, string modelType)
        {
            if (!Enum.TryParse(modelType, true, out ServiceType serviceType))
            {
                throw new Exception($"Unknown model type: {modelType}");
            }

            var comment = new Comment
            {
                Content = commentText,
                CreatedAt = DateTime.Now,
                UserId = userName,
                ServiceId = modelId,
                ServiceType = serviceType
            };

            try
            {
                _commentRepo.insert(comment); 
                await Clients.All.SendAsync("NewCommentNotify", userName, commentText);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CommentHub: {ex.Message}");
                throw new Exception("Error processing the comment", ex);  
            }
        }

    }
}

