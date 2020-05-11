using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ONIT.VismaNetApi.Lib;
using ONIT.VismaNetApi.Models.CustomDto;
using ONIT.VismaNetApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONIT.VismaNetApi.Models
{
    public class CustomerCreditNote : DtoPaginatedProviderBase, IProvideIdentificator
    {
        private List<Attachment> _attachments;

        public CustomerCreditNote()
        {
            IgnoreProperties.Add(nameof(referenceNumber));
        }

        /// <summary>
        ///     Create a new customer invoice without auto numbering
        /// </summary>
        /// <param name="referenceNumber"></param>
        public CustomerCreditNote(string referenceNumber)
        {
            this.referenceNumber = referenceNumber;
        }

        [JsonProperty]
        public Account account
        {
            get; // => Get<Account>("accountNumber");
            private set; //set => Set(value, "accountNumber");
        }

        [JsonProperty]
        public decimal amount
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        [JsonProperty]
        public decimal amountInCurrency
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        [JsonProperty]
        public List<Attachment> attachments
        {
            get => _attachments ?? (_attachments = new List<Attachment>());
            private set => _attachments = value;
        }

        [JsonProperty]
        public decimal balance
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        [JsonProperty]
        public decimal balanceInCurrency
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        public NumberName branchNumber
        {
            get => Get<NumberName>();
            set => Set(value);
        }

        public string cashAccount
        {
            get => Get<string>();
            set => Set(value);
        }

        [JsonProperty]
        public decimal cashDiscount
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        public DateTime cashDiscountDate
        {
            get => Get<DateTime>();
            set => Set(value);
        }

        [JsonProperty]
        public decimal cashDiscountInCurrency
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }


        [JsonProperty] public string closedFinancialPeriod { get; private set; }

        [JsonProperty]
        public ContactSummary contact
        {
            get => Get<ContactSummary>();
            set => Set(value);
        }

        [JsonProperty]
        public DateTime createdDateTime
        {
            get; // { return Get<DateTime>(); }
            private set; // { Set(value); }
        }

        public CreditTerms creditTerms
        {
            get => Get<CreditTerms>("creditTermsId");
            set => Set(value, "creditTermsId");
        }

        public string currencyId
        {
            get => Get<string>();
            set => Set(value);
        }

        public CustomerSummary customer
        {
            get => Get<CustomerSummary>("customerNumber", new CustomerSummary());
            set => Set(value, "customerNumber");
        }


        public string customerRefNumber
        {
            get => Get<string>();
            set => Set(value);
        }

        public CustomerVatZone customerVatZone
        {
            get => Get<CustomerVatZone>("customerVatZoneId");
            set => Set(value, "customerVatZoneId");

        }

        [JsonProperty]
        public decimal detailTotal
        {
            get; //{ return Get<decimal>(); }
            private set; // { Set(value); }
        }

        [JsonProperty]
        public decimal detailTotalInCurrency
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        public DateTime documentDate
        {
            get => Get<DateTime>();
            set => Set(value);
        }

        public DateTime documentDueDate
        {
            get => Get<DateTime>();
            set => Set(value);
        }

        [JsonProperty]
        public CustomerDocumentType documentType
        {
            get; // { return Get<CustomerDocumentType>(); }
            private set; // { Set(value); }
        }

        [JsonProperty] public DateTime dunningLetterDate { get; private set; }

        [JsonProperty] public int dunningLetterLevel { get; private set; }

        [JsonProperty] public string errorInfo { get; private set; }

        public decimal exchangeRate
        {
            get => Get<decimal>();
            set
            {
                if (value == 1)
                    IgnoreProperties.Add(nameof(exchangeRate));
                else if (IgnoreProperties.Contains(nameof(exchangeRate)))
                    IgnoreProperties.Remove(nameof(exchangeRate));
                Set(value);
            }
        }

        public string externalReference
        {
            get => Get<string>();
            set => Set(value);
        }

        [JsonProperty] public JObject extras { get; private set; }

        public string financialPeriod
        {
            get => Get<string>();
            set => Set(value);
        }

        public bool hold
        {
            get => Get<bool>();
            set => Set(value);
        }

        // This is only editable from the method Add (with overloads) on Invoice
        [JsonProperty]
        public List<CustomerCreditNoteLine> lines
        {
            get => Get(defaultValue: new List<CustomerCreditNoteLine>());
            private set => Set(value);
        }

        public string invoiceText
        {
            get => Get<string>();
            set => Set(value);
        }

        public bool isRotRutDeductible
        {
            get => Get<bool>("domesticServicesDeductibleDocument");
            set => Set(value, "domesticServicesDeductibleDocument");
        }

        [JsonProperty]
        public DateTime lastModifiedDateTime
        {
            get; // { return Get<DateTime>(); }
            private set; // { Set(value); }
        }

        public LocationSummary location
        {
            get => Get("locationId", new LocationSummary());
            set => Set(value, "locationId");
        }

        public string note
        {
            get => Get<string>();
            set => Set(value);
        }

        public PaymentMethod paymentMethod
        {
            get => Get<PaymentMethod>("paymentMethodId");
            set => Set(value, "paymentMethodId");
        }

        public string paymentReference
        {
            get => Get<string>();
            set => Set(value);
        }

        public string postPeriod
        {
            get => Get<string>();
            set => Set(value);
        }

        [JsonProperty]
        public DescriptiveDto project
        {
            get => Get<DescriptiveDto>();
            set => Set(value);
        }

        public string referenceNumber
        {
            get => Get<string>();
            set => Set(value);
        }

        [JsonProperty]
        public DescriptiveDto salesPerson
        {
            get => Get<DescriptiveDto>();
            set => Set(value);
        }

        /* public RotRutDetails rotRutDetails
        {
            get => Get(defaultValue: new RotRutDetails());
            set => Set(value);
        }*/

        [JsonProperty]
        public string salesPersonDescr
        {
            get; // { return Get<string>(); }
            private set; // { Set(value); }
        }

        public int? salesPersonID
        {
            get => Get<int?>();
            set => Set(value);
        }

        [JsonProperty]
        public InvoiceStatus status
        {
            get; // { return Get<InvoiceStatus>(); }
            private set; // { Set(value); }
        }

        [JsonProperty] public Subaccount subaccount { get; private set; }

        [JsonProperty]
        public List<TaxDetail> TaxDetails
        {
            get; //=> Get("taxDetailLines", new List<TaxDetail>());

            private set; //=> Set(value, "taxDetailsLines");
        }

        [JsonProperty]
        public List<Applications> applications
        {
            get;
            private set;
        }

        [JsonProperty]
        public decimal vatExemptTotal
        {
            get;
            private set;
        }

        [JsonProperty]
        public decimal vatExemptTotalInCurrency
        {
            get;
            private set;
        }

        [JsonProperty]
        public decimal vatTaxableTotal
        {
            get;
            private set;
        }

        [JsonProperty]
        public decimal vatTaxableTotalInCurrency
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        [JsonProperty]
        public decimal vatTotal
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }

        [JsonProperty]
        public decimal vatTotalInCurrency
        {
            get; // { return Get<decimal>(); }
            private set; // { Set(value); }
        }
        [JsonProperty]
        public decimal roundingDiff
        {
            get;
            private set;
        }

        public string GetIdentificator()
        {
            return referenceNumber;
        }

        public void Add(CustomerCreditNoteLine line)
        {
            line.lineNumber = 1;
            if (lines.Count > 0)
                line.lineNumber = Math.Max(lines.Count + 1, lines.Max(x => x.lineNumber) + 1);
            lines.Add(line);
        }

        public void Add(string inventoryId, int quantity = 1)
        {
            Add(new CustomerCreditNoteLine
            {
                inventoryNumber = inventoryId,
                quantity = quantity
            });
        }

        internal override void PrepareForUpdate()
        {
            foreach (var line in lines)
                line.operation = ApiOperation.Update;
        }
    }
}
