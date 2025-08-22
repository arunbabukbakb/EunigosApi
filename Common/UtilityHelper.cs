using EunigosApi.Data;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity;
using FluentValidation.Results;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using EunigosApi.Models.Entity.UserManagement;
namespace EunigosApi.Common
{
    public class UtilityHelper
    {
        private static readonly Random _random = new Random();
        public static ApiResponse<T> CreateSuccessResponse<T>(T data, List<Error> message)
        {
            return new ApiResponse<T>(true, message, data);
        }

        public static ApiResponse<T> CreateErrorResponse<T>(List<Error> message)
        {
            return new ApiResponse<T>(false, message, default(T));
        }


        public static ApiResponse4<T> CreateSuccessResponse1<T>(T data, List<Error> message, T? meta)
        {
            return new ApiResponse4<T>(message, data, meta);
        }

        public static ApiResponse4<T> CreateErrorResponse1<T>(List<Error> message, T? meta)
        {
            return new ApiResponse4<T>(message, default(T), meta);
        }

        public static List<Error> CustomMessage(ValidationResult obj)
        {
            var customErrors = new List<Error>();

            foreach (var errors in obj.Errors)
            {
                customErrors.Add(new Error
                {
                    Field = errors.PropertyName,
                    Message = errors.ErrorMessage,
                    Code = errors.ErrorCode,
                    //Details = errors.ErrorDetail

                });
            }
            return customErrors;
        }
        public static string ToPascalCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            // Split words by non-alphanumeric characters like underscores, hyphens, etc.
            var words = input.Split(new[] { '_', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = string.Concat(words.Select(word =>
                char.ToUpperInvariant(word[0]) + word.Substring(1).ToLowerInvariant()));

            return result;
        }
        public static List<Error> CustomMessage(string code, string message, string property = "")
        {
            List<Error> validationMessages = new List<Error>
                {
                new Error{
                    Code=code,
                    Message=message,
                    Field=property}
                };
            return validationMessages;
        }


        // Assuming this is in a UtilityHelper class
        public static PaginationDto GetPagination<T>(PagedResult<T> data)
        {
            return new PaginationDto
            {
                Total = data.TotalItems,
                Limit = data.PageSize,
                Page = data.PageNumber,
                Pages = data.TotalPages,
                Start = data.Start,
                End = data.End,
            };
        }


        public static string GeneratedNewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static string SetCreatedBy()
        {
            return "System";
        }

        public static string SetUpdatedBy()
        {
            return "System";
        }

        public static string SetDeletedBy()
        {
            return "System";
        }

        public static DateTime SetCreatedAt()
        {
            return DateTime.Now;
        }
        public static DateTime SetUpdatedAt()
        {
            return DateTime.Now;
        }
        public static DateTime SetDeletedAt()
        {
            return DateTime.Now;
        }

        public static string SetTenantId()
        {
            return "7ee627c6-ded7-422e-b466-0ff0cda27e9c";
        }


        // Helper method to generate a refresh token
        public static string GenerateRefreshToken()
        {
            var randomBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }


        /// <summary>
        /// create jwt token
        /// </summary>
        /// <param name="claim">list of claims</param>
        /// <param name="expireAt">claims expire time </param>
        /// <returns>Jwt token</returns>
        public static string CreateToken(IEnumerable<Claim> claim, DateTime expireAt, byte[]? secretkey)
        {


            var jwt = new JwtSecurityToken(
                claims: claim,
                notBefore: DateTime.UtcNow,
                expires: expireAt,
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(secretkey),
                    SecurityAlgorithms.HmacSha256Signature));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
        /// <summary>
        /// Generate Random Ticket number ex(T20250608133512004923)
        /// </summary>


        public static async Task<string> GenerateTicketNumber(ApplicationDbContext dbContext)
        {
            var docNo = await dbContext.Ticket
                .OrderByDescending(e => e.CreatedAt)
                .Select(e => e.TicketNumber)
                .FirstOrDefaultAsync();

            int nextNumber = 1;

            if (!string.IsNullOrEmpty(docNo) && int.TryParse(docNo.TrimStart('T'), out int currentNumber))
            {
                nextNumber = currentNumber + 1;
            }

            return $"T{nextNumber:D7}";
        }
        public static async Task<string> GenerateNextEstimateNumberAsync(ApplicationDbContext dbContext)
        {
            var estimateNo = await dbContext.Estimate
                .Where(e => !e.IsClone && !e.IsSupplementary && !e.IsCopy &&
                !e.EstimateNumber.Contains("-c") &&
                !e.EstimateNumber.Contains("-s"))
                .OrderByDescending(e => e.CreatedAt)
                .Select(e => e.EstimateNumber)
                .FirstOrDefaultAsync();

            int nextNumber = 1;

            if (!string.IsNullOrEmpty(estimateNo) &&
                int.TryParse(estimateNo, out int currentNumber))
            {
                nextNumber = currentNumber + 1;
            }

            return $"E{nextNumber:D7}";
        }

        /// <summary>
        /// Generates a DateTime representing the expiration time for a token or resource.
        /// </summary>
        /// <param name="minutesToExpire">The number of minutes until the token expires.</param>
        /// <returns>A DateTime in UTC representing the expiration time.</returns>
        public static DateTime GenerateExpirationTime(int minutesToExpire)
        {
            return DateTime.UtcNow.AddMinutes(minutesToExpire);
        }

        /// <summary>
        /// Generates a list of claims based on the provided user details.
        /// </summary>
        /// <param name="user">The user object containing details for claims.</param>
        /// <returns>A list of claims.</returns>
        public static List<Claim> GenerateClaims(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            return new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName ?? string.Empty),
            new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
            new Claim(ClaimTypes.Role, user.RoleId ?? string.Empty)
        };
        }

    }
}
