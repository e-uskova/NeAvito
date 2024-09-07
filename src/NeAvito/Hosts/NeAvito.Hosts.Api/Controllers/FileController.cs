using Microsoft.AspNetCore.Mvc;
using NeAvito.Application.AppServices.File.Services;
using NeAvito.Contracts.File;
using System.Net;

namespace NeAvito.Hosts.Api.Controllers
{
    /// <summary>
    /// Файлы
    /// </summary>
    [ApiController]
    [Route("/files")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="fileService">Сервис для работы с файлами</param>
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        /// <summary>
        /// Загрузка файла в систему
        /// </summary>
        /// <param name="file">Файл</param>
        /// <param name="adId">Идентификатор объявления</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile file, Guid adId, CancellationToken cancellationToken)
        {
            var bytes = await GetBytesAsync(file, cancellationToken);
            var fileCreateDto = new FileCreateDto
            {
                Name = file.FileName,
                Content = bytes,
                ContentType = file.ContentType,
                Length = bytes.Length,
                Created = DateTime.UtcNow,
                AdId = adId,
            };

            var result = await _fileService.AddAsync(fileCreateDto, cancellationToken);

            return result == Guid.Empty ? BadRequest() : StatusCode((int)HttpStatusCode.Created, result);
        }

        /// <summary>
        /// Скачивание файла
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> DownloadAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _fileService.GetAsync(id, cancellationToken);
            if (result == null)
            {
                return NotFound();
            }
            Response.ContentLength = result.Content.Length;
            return File(result.Content, result.ContentType, result.Name);
        }

        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _fileService.DeleteAsync(id, cancellationToken);
            return result ? BadRequest() : Ok();
        }

        private async Task<byte[]> GetBytesAsync(IFormFile file, CancellationToken cancellationToken)
        {
            var ms = new MemoryStream();
            await file.CopyToAsync(ms, cancellationToken);
            return ms.ToArray();
        }
    }
}
