﻿using Application.DTOs.Issues;

namespace Application.Services
{
    public class IssueLabelService : IIssueLabelService
    {
        private readonly IIssueLabelRepository _repo;

        public IssueLabelService(IIssueLabelRepository repo)
        {
            _repo = repo;
        }

        public async Task<AssignLabelToIssueDto> AssignLabelToIssueAsync(AssignLabelToIssueDto dto)
        {
            var link = new IssueLabel
            {
                IssueId = dto.IssueId,
                LabelId = dto.LabelId
            };

            var created = await _repo.AddAsync(link);

            return new AssignLabelToIssueDto
            {
                IssueId = created.IssueId,
                LabelId = created.LabelId
            };
        }

        public async Task<bool> RemoveLabelFromIssueAsync(int issueId, int labelId)
        {
            var link = await _repo.GetByIdAsync(new { issueId, labelId });
            if (link == null) return false;

            return await _repo.DeleteAsync(new { issueId, labelId });
        }
    }
}
