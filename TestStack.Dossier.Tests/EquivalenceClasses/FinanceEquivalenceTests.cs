﻿using System.Collections.Generic;
using TestStack.Dossier.DataSources;
using TestStack.Dossier.DataSources.Dictionaries;
using Xunit.Extensions;

namespace TestStack.Dossier.Tests.EquivalenceClasses
{
    public class FinanceEquivalenceTests : FileDictionaryEquivalenceTests
    {
        [Theory]
        [ClassData(typeof(FinanceTestCases))]
        public override void WhenGettingAnyData_ThenReturnRandomDataWhichIsReasonablyUnique(DataSource<string> source, List<string> testCases)
        {
            base.WhenGettingAnyData_ThenReturnRandomDataWhichIsReasonablyUnique(source, testCases);
        }
    }

    public class FinanceTestCases : FileDictionaryEquivalenceTestCases
    {
        protected override List<object[]> GetData()
        {
            return new List<object[]>
            {
                new object[]
                {new Words(FromDictionary.FinanceCreditCardNumber), GenerateTestCasesForSut(Any.FinanceCreditCardNumber)},
                new object[]
                {new Words(FromDictionary.FinanceCreditCardType), GenerateTestCasesForSut(Any.FinanceCreditCardType)},
                new object[]
                {new Words(FromDictionary.FinanceCurrency), GenerateTestCasesForSut(Any.FinanceCurrency)},
                new object[]
                {new Words(FromDictionary.FinanceCurrencyCode), GenerateTestCasesForSut(Any.FinanceCurrencyCode)}
            };
        }
    }
}
