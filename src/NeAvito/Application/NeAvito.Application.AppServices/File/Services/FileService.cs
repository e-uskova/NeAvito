using NeAvito.Application.AppServices.File.Repository;
using NeAvito.Contracts.File;

namespace NeAvito.Application.AppServices.File.Services
{
    /// <inheritdoc/>
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;

        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        public Task<Guid> AddAsync(FileCreateDto fileCreateDto, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            var fileDto = new FileDto() 
            { 
                Id = id,
                Name = fileCreateDto.Name,
                Content = fileCreateDto.Content,
                ContentType = fileCreateDto.ContentType,
                Length = fileCreateDto.Length,
                Created = fileCreateDto.Created,
                AdId = fileCreateDto.AdId,
            };
            return _fileRepository.AddAsync(fileDto, cancellationToken);
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return _fileRepository.DeleteAsync(id, cancellationToken);
        }

        public Task<FileDto> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return GetAsync(id, cancellationToken);
        }

        public Task<FileInfoDto> GetInfoAsync(Guid id, CancellationToken cancellationToken)
        {
            return GetInfoAsync(id, cancellationToken);
        }
    }
}
