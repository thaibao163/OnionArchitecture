﻿//using CloudinaryDotNet;
//using CloudinaryDotNet.Actions;
//using Domain.ViewModel.Clouds;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Options;

//namespace Persistence.Services.Clouds
//{
//    public class CloudinaryService : ICloudinaryService
//    {
//        private readonly Cloudinary _cloudinary;

//        public CloudinaryService(IOptions<CloudinarySettings> settings)
//        {
//            var account = new Account(
//              settings.Value.CouldName,
//              settings.Value.ApiKey,
//              settings.Value.ApiSecret
//            );

//            _cloudinary = new Cloudinary(account);
//        }

//        public async Task<DeletionResult> DeleteImageAsync(string publicId)
//        {
//            var deleteParams = new DeletionParams(publicId);
//            var result = await _cloudinary.DestroyAsync(deleteParams);

//            return result;
//        }

//        public async Task<ImageUploadResult> UploadImageAsync(IFormFile file)
//        {
//            var uploadResult = new ImageUploadResult();

//            if (file.Length > 0)
//            {
//                using var stream = file.OpenReadStream();
//                var uploadParams = new ImageUploadParams
//                {
//                    File = new FileDescription(file.FileName, stream),
//                };

//                uploadResult = await _cloudinary.UploadAsync(uploadParams);
//            }

//            return uploadResult;
//        }
//    }
//}