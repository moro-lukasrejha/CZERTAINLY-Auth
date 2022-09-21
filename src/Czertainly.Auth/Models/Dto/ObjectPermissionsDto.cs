﻿using Czertainly.Auth.Common.Models.Dto;
using System.ComponentModel.DataAnnotations;

namespace Czertainly.Auth.Models.Dto
{
    public record ObjectPermissionsDto
    {
        [Required]
        public Guid Uuid { get; set; }

        [Required]
        public List<string> Allow { get; init; } = new List<string>();

        [Required]
        public List<string> Deny { get; init; } = new List<string>();

    }
}
