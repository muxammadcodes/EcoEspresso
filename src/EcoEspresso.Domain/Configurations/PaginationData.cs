﻿namespace EcoEspresso.Domain.Configurations
{
    public class PaginationData
    {
        public int CurrentPage { get; set; }
        public int TotalCount { get; set; }
        public int TotalPage { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalCount;

        public PaginationData(int totalCount,PaginationParams @params)
        {
            CurrentPage = @params.PageIndex;
            TotalCount = totalCount;

            TotalPage =(int)Math.Ceiling(totalCount / (double)@params.PageSize);
        }
    }
}
