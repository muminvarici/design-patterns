using SimpleApi.Models;

namespace SimpleApi.Services.Facades;

public class ApiFacade
{
    private readonly IAlbumsApi _albumsApi;
    private readonly ICommentsApi _commentsApi;
    private readonly IPhotosApi _photosApi;
    private readonly IPostsApi _postsApi;
    private readonly ITodosApi _todosApi;
    private readonly IUsersApi _usersApi;

    public ApiFacade
    (
        IUsersApi usersApi,
        ITodosApi todosApi,
        IPostsApi postsApi,
        IPhotosApi photosApi,
        ICommentsApi commentsApi,
        IAlbumsApi albumsApi
    )
    {
        _usersApi = usersApi;
        _todosApi = todosApi;
        _postsApi = postsApi;
        _photosApi = photosApi;
        _commentsApi = commentsApi;
        _albumsApi = albumsApi;
    }

    public async Task<IEnumerable<Album>> GetAllAlbums()
    {
        return await _albumsApi.GetAllAlbums();
    }

    public async Task<IEnumerable<Comment>> GetAllComments()
    {
        return await _commentsApi.GetAllComments();
    }

    public async Task<IEnumerable<Photo>> GetAllPhotos()
    {
        return await _photosApi.GetAllPhotos();
    }

    public async Task<IEnumerable<Post>> GetAllPosts()
    {
        return await _postsApi.GetAllPosts();
    }

    public async Task<IEnumerable<Todo>> GetAllTodos()
    {
        return await _todosApi.GetAllTodos();
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await _usersApi.GetAllUsers();
    }
}