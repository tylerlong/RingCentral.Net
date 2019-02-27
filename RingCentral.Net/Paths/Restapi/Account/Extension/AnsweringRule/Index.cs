using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AnsweringRule
{
    public partial class Index
    {
        public RestClient rc;
        public string ruleId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string ruleId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.ruleId = ruleId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ruleId != null)
            {
                return $"{parent.Path()}/answering-rule/{ruleId}";
            }

            return $"{parent.Path()}/answering-rule";
        }

        // Operation: listAnsweringRules
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule
        public async Task<RingCentral.UserAnsweringRuleList> List(ListAnsweringRulesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.UserAnsweringRuleList>(this.Path(false), queryParams);
        }

        // Operation: createAnsweringRule
        // Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule
        public async Task<RingCentral.AnsweringRuleInfo> Post(
            RingCentral.CreateAnsweringRuleRequest createAnsweringRuleRequest)
        {
            return await rc.Post<RingCentral.AnsweringRuleInfo>(this.Path(false), createAnsweringRuleRequest);
        }

        // Operation: loadAnsweringRule
        // Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        public async Task<RingCentral.AnsweringRuleInfo> Get(LoadAnsweringRuleParameters queryParams = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.AnsweringRuleInfo>(this.Path(), queryParams);
        }

        // Operation: updateAnsweringRule
        // Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        public async Task<RingCentral.AnsweringRuleInfo> Put(
            RingCentral.UpdateAnsweringRuleRequest updateAnsweringRuleRequest)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.AnsweringRuleInfo>(this.Path(), updateAnsweringRuleRequest);
        }

        // Operation: deleteAnsweringRule
        // Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        public async Task<string> Delete()
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AnsweringRule.Index AnsweringRule(string ruleId = null)
        {
            return new Restapi.Account.Extension.AnsweringRule.Index(this, ruleId);
        }
    }
}