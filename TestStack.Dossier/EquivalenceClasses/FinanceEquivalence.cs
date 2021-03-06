using TestStack.Dossier.DataSources.Dictionaries;

// ReSharper disable once CheckNamespace
namespace TestStack.Dossier
{
    /// <summary>
    /// Extension methods that describe equivalence classes for generating anonymous Finance-related values.
    /// </summary>
    public static class FinanceEquivalence
    {
        /// <summary>
        /// Generate and return a finance credit card number.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string FinanceCreditCardNumber(this AnonymousValueFixture fixture)
        {
            return fixture.Words(FromDictionary.FinanceCreditCardNumber).Next();
        }

        /// <summary>
        /// Generate and return a finance credit card type.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string FinanceCreditCardType(this AnonymousValueFixture fixture)
        {
            return fixture.Words(FromDictionary.FinanceCreditCardType).Next();
        }

        /// <summary>
        /// Generate and return a finance currency name.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string FinanceCurrency(this AnonymousValueFixture fixture)
        {
            return fixture.Words(FromDictionary.FinanceCurrency).Next();
        }

        /// <summary>
        /// Generate and return a finance currency code.
        /// </summary>
        /// <param name="fixture">The fixture to generate a value for.</param>
        /// <returns>The generated value.</returns>
        public static string FinanceCurrencyCode(this AnonymousValueFixture fixture)
        {
            return fixture.Words(FromDictionary.FinanceCurrencyCode).Next();
        }

    }
}