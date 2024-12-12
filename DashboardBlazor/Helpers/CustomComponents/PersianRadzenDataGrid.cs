using Radzen.Blazor;

namespace DashboardBlazor.Helpers.CustomComponents
{
    class PersianRadzenDataGrid<T> : RadzenDataGrid<T>
    {
        public PersianRadzenDataGrid()
        {
            FilterText = "فیلتر";
            ClearFilterText = "پاک";
            ApplyFilterText = "اعمال";

            EqualsText = "برابر است";
            NotEqualsText = "برابر نیست";
            ContainsText = "شامل";
            StartsWithText = "شروع با";
            EndsWithText = "پایان با";
            DoesNotContainText = "شامل نمی شود";
            IsNullText = "تهی";
            IsEmptyText = "خالی";
            IsNotNullText = "تهی نیست";
            IsNotEmptyText = "خالی نیست";

            LessThanText = "کمتر از";
            LessThanOrEqualsText = "کمتر یا مساوی";
            GreaterThanText = "بیشتر از";
            GreaterThanOrEqualsText = "بیشتر یا مساوی";

            AndOperatorText = "و";
            OrOperatorText = "یا";

            FirstPageTitle = "صفحه اول";
            LastPageTitle = "صفحه آخر";
            PrevPageTitle = "صفحه قبلی";
            NextPageTitle = "صفحه بعدی";

            EmptyText = "هیچ رکوردی برای نمایش وجود ندارد.";

            PageTitleFormat = "صفحه {0}";
            PagingSummaryFormat = "صفحه {0} از {1} ({2} مورد)";
        }
    }
}
