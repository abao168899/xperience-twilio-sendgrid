﻿namespace Kentico.Xperience.Twilio.SendGrid
{
    /// <summary>
    /// Constants used in the SendGrid integration.
    /// </summary>
    public class SendGridConstants
    {
        /// <summary>
        /// The API key for using the SendGrid API.
        /// </summary>
        public const string APPSETTING_API_KEY = "SendGridApiKey";

        /// <summary>
        /// Enables bypassing the bounce list to ensure that the email is delivered
        /// to recipients. Spam report and unsubscribe lists will still be checked; addresses
        /// on these other lists will not receive the message.
        /// </summary>
        public const string APPSETTING_BYPASS_BOUNCE = "SendGridBypassBounces";


        /// <summary>
        /// Enables the bypass of all unsubscribe groups and suppressions to ensure
        /// that the email is delivered to every single recipient. This should only be used
        /// in emergencies when it is absolutely necessary that every recipient receives
        /// your email. Ex: outage emails, or forgot password emails.
        /// </summary>
        public const string APPSETTING_BYPASS_GROUPS_SUPPRESSION = "SendGridBypassGroupsAndSuppressions";


        /// <summary>
        /// Enables the bypass the global unsubscribe list to ensure that the email
        /// is delivered to recipients. Bounce and spam report lists will still be checked;
        /// addresses on these other lists will not receive the message. This filter applies
        /// only to global unsubscribes and will not bypass group unsubscribes.
        /// </summary>
        public const string APPSETTING_BYPASS_GLOBAL_UNSUBSCRIBE = "SendGridBypassGlobalUnsubscribes";


        /// <summary>
        /// Enables the bypass of spam report list to ensure that the email is delivered
        /// to recipients. Bounce and unsubscribe lists will still be checked; addresses
        /// on these other lists will not receive the message.
        /// </summary>
        public const string APPSETTING_BYPASS_SPAM = "SendGridBypassSpam";


        /// <summary>
        /// Enables tracking whether a recipient clicked a link in your email.
        /// </summary>
        public const string APPSETTING_ENABLE_CLICK_TRACKING = "SendGridEnableClickTracking";


        /// <summary>
        /// Enables tracking provided by Google Analytics.
        /// </summary>
        public const string APPSETTING_ENABLE_GANALYTICS = "SendGridEnableGoogleAnalytics";


        /// <summary>
        /// Enables tracking whether the email was opened or not, by including a single
        /// pixel image in the body of the content. When the pixel is loaded, we can log
        /// that the email was opened.
        /// </summary>
        public const string APPSETTING_ENABLE_OPEN_TRACKING = "SendGridEnableOpenTracking";


        /// <summary>
        /// Enables a subscription management link at the bottom of the text
        /// and html bodies of your email. If you would like to specify the location of the
        /// link within your email, you may use the substitution_tag.
        /// </summary>
        public const string APPSETTING_ENABLE_SUBSCRIPTION_TRACKING = "SendGridEnableSubscriptionTracking";


        /// <summary>
        /// Sets the IP Pool that you would like to send emails from.
        /// </summary>
        /// <remarks>See <see href="https://docs.sendgrid.com/ui/account-and-settings/ip-pools"/>.</remarks>
        public const string APPSETTING_IP_POOL_NAME = "SendGridIpPoolName";


        /// <summary>
        /// Enables the ability to send a test email to ensure that your request body
        /// is valid and formatted correctly.
        /// </summary>
        /// <remarks>See <see href="https://sendgrid.com/docs/Classroom/Send/v3_Mail_Send/sandbox_mode.html"/>.</remarks>
        public const string APPSETTING_SANDBOX_MODE = "SendGridSandboxMode";


        /// <summary>
        /// A key generated by SendGrid to verify the source of a webhook POST.
        /// </summary>
        public const string APPSETTING_WEBHOOK_KEY = "SendGridWebhookVerificationKey";


        /// <summary>
        /// The key of the header storing the SendGrid webhook signature.
        /// </summary>
        public const string HEADER_WEBHOOK_SIGNATURE = "X-Twilio-Email-Event-Webhook-Signature";


        /// <summary>
        /// The key of the header storing the SendGrid webhook timestamp.
        /// </summary>
        public const string HEADER_WEBHOOK_TIMESTAMP = "X-Twilio-Email-Event-Webhook-Timestamp";
    }
}