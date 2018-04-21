// Dynamics 365 svcutil extension tool by Kipon ApS, Kjeld Poulsen
// This file is autogenerated. Do not touch the code manually

namespace Kipon.Dynamics.Plugin.Entities
{
	public partial class CrmUnitOfWork
	{
		private IRepository<Account> _accounts; 
		public IRepository<Account> Accounts
		{
			get
			{
				if (_accounts == null)
					{
						_accounts = new CrmRepository<Account>(this.context);
					}
				return _accounts;
			}
		}
		private IRepository<Contact> _contacts; 
		public IRepository<Contact> Contacts
		{
			get
			{
				if (_contacts == null)
					{
						_contacts = new CrmRepository<Contact>(this.context);
					}
				return _contacts;
			}
		}
		private IRepository<Opportunity> _opportunities; 
		public IRepository<Opportunity> Opportunities
		{
			get
			{
				if (_opportunities == null)
					{
						_opportunities = new CrmRepository<Opportunity>(this.context);
					}
				return _opportunities;
			}
		}
		private IRepository<SalesOrder> _salesorders; 
		public IRepository<SalesOrder> Salesorders
		{
			get
			{
				if (_salesorders == null)
					{
						_salesorders = new CrmRepository<SalesOrder>(this.context);
					}
				return _salesorders;
			}
		}
		private IRepository<Quote> _quotes; 
		public IRepository<Quote> Quotes
		{
			get
			{
				if (_quotes == null)
					{
						_quotes = new CrmRepository<Quote>(this.context);
					}
				return _quotes;
			}
		}
		private IRepository<SystemUser> _systemusers; 
		public IRepository<SystemUser> Systemusers
		{
			get
			{
				if (_systemusers == null)
					{
						_systemusers = new CrmRepository<SystemUser>(this.context);
					}
				return _systemusers;
			}
		}
	}
}
