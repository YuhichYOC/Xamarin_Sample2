﻿using Prism.Mvvm;

namespace BlankApp3.Models
{
    public class TestDataRow : BindableBase
    {
        private string property1;

        private string property2;

        private string property3;

        private int property4;

        public string Property1
        {
            get => property1;
            set => SetProperty(ref property1, value, CopyProp1ToBranchRow);
        }

        public string Property2
        {
            get => property2;
            set => SetProperty(ref property2, value);
        }

        public string Property3
        {
            get => property3;
            set => SetProperty(ref property3, value);
        }

        public int Property4
        {
            get => property4;
            set => SetProperty(ref property4, value);
        }

        public TestDataRowBranch BranchRow { get; }

        public TestDataRow(TestDataRowBranch arg)
        {
            BranchRow = arg;
        }

        private void CopyProp1ToBranchRow()
        {
            BranchRow.TestValue = Property1;
        }
    }
}