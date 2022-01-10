﻿// Copyright (c) 2016, Dijji, and released under Ms-PL.  This can be found in the root of this distribution. 

using System.Collections.Generic;

namespace XstReader.ItemProperties
{
    internal class StandardProperties
    {
        // Message properties as defined in [MS-OXPROPS]
        // The list is not exhaustive, consisting of message properties actually seen to date
        // "undocumented" means that the property has been seen, but is not in [MS-OXPROPS]
        public static Dictionary<PropertyCanonicalName, string> TagToDescription = new Dictionary<PropertyCanonicalName, string>
        {
            {(PropertyCanonicalName)0x0002,        "AlternateRecipientAllowed" },
            {(PropertyCanonicalName)0x0003,        "AuthorizingUsers" },
            {(PropertyCanonicalName)0x0004,        "AutoForwardComment" },
            {(PropertyCanonicalName)0x0005,        "AutoForwarded" },
            {(PropertyCanonicalName)0x0006,        "ContentConfidentialityAlgorithmId" },
            {(PropertyCanonicalName)0x0007,        "ContentCorrelator" },
            {(PropertyCanonicalName)0x0008,        "ContentIdentifier" },
            {(PropertyCanonicalName)0x0009,        "ContentLength" },
            {(PropertyCanonicalName)0x000a,        "ContentReturnRequested" },
            {(PropertyCanonicalName)0x000b,        "ConversationKey" },
            {(PropertyCanonicalName)0x000c,        "ConversionEits" },
            {(PropertyCanonicalName)0x000d,        "ConversionWithLossProhibited" },
            {(PropertyCanonicalName)0x000e,        "ConvertedEits" },
            {(PropertyCanonicalName)0x000f,        "DeferredDeliveryTime" },
            {(PropertyCanonicalName)0x0010,        "DeliverTime" },
            {(PropertyCanonicalName)0x0011,        "DiscardReason" },
            {(PropertyCanonicalName)0x0012,        "DisclosureOfRecipients" },
            {(PropertyCanonicalName)0x0013,        "DistributionListExpansionHistory" },
            {(PropertyCanonicalName)0x0014,        "DistributionListExpansionProhibited" },
            {(PropertyCanonicalName)0x0015,        "ExpiryTime" },
            {(PropertyCanonicalName)0x0016,        "ImplicitConversionProhibited" },
            {(PropertyCanonicalName)0x0017,        "Importance" },
            {(PropertyCanonicalName)0x0018,        "PROP_ACCT_DELIVERY_STORE" },
            {(PropertyCanonicalName)0x0019,        "LatestDeliveryTime" },
            {(PropertyCanonicalName)0x001a,        "MessageClass" },
            {(PropertyCanonicalName)0x001b,        "MessageDeliveryId" },
            {(PropertyCanonicalName)0x001e,        "MessageSecurityLabel" },
            {(PropertyCanonicalName)0x001f,        "ObsoletedMessageIds" },
            {(PropertyCanonicalName)0x0020,        "OriginallyIntendedRecipientName" },
            {(PropertyCanonicalName)0x0021,        "OriginalEits" },
            {(PropertyCanonicalName)0x0022,        "OriginatorCertificate" },
            {(PropertyCanonicalName)0x0023,        "OriginatorDeliveryReportRequested" },
            {(PropertyCanonicalName)0x0024,        "OriginatorReturnAddress" },
            {(PropertyCanonicalName)0x0025,        "ParentKey" },
            {(PropertyCanonicalName)0x0026,        "Priority" },
            {(PropertyCanonicalName)0x0027,        "OriginCheck" },
            {(PropertyCanonicalName)0x0028,        "ProofOfSubmissionRequested" },
            {(PropertyCanonicalName)0x0029,        "ReadReceiptRequested" },
            {(PropertyCanonicalName)0x002a,        "ReceiptTime" },
            {(PropertyCanonicalName)0x002b,        "RecipientReassignmentProhibited" },
            {(PropertyCanonicalName)0x002c,        "RedirectionHistory" },
            {(PropertyCanonicalName)0x002d,        "RelatedMessageIds" },
            {(PropertyCanonicalName)0x002e,        "OriginalSensitivity" },
            {(PropertyCanonicalName)0x002f,        "Languages" },
            {(PropertyCanonicalName)0x0030,        "ReplyTime" },
            {(PropertyCanonicalName)0x0031,        "ReportTag" },
            {(PropertyCanonicalName)0x0032,        "ReportTime" },
            {(PropertyCanonicalName)0x0036,        "Sensitivity" },
            {PropertyCanonicalName.PidTagSubject, "Subject" },
            {PropertyCanonicalName.PidTagClientSubmitTime, "ClientSubmitTime" },
            {(PropertyCanonicalName)0x003b,        "SentRepresentingSearchKey" },
            {(PropertyCanonicalName)0x003d,        "SubjectPrefix" },
            {(PropertyCanonicalName)0x003f,        "ReceivedByEntryId" },
            {(PropertyCanonicalName)0x0040,        "ReceivedByName" },
            {(PropertyCanonicalName)0x0041,        "SentRepresentingEntryId" },
            {PropertyCanonicalName.PidTagSentRepresentingName, "SentRepresentingName" },
            {(PropertyCanonicalName)0x0043,        "ReceivedRepresentingEntryId" },
            {(PropertyCanonicalName)0x0044,        "ReceivedRepresentingName" },
            {(PropertyCanonicalName)0x0046,        "ReadReceiptEntryId" },
            {(PropertyCanonicalName)0x0047,        "MessageSubmissionId" },
            {(PropertyCanonicalName)0x0048,        "ProviderSubmitTime" },
            {(PropertyCanonicalName)0x0049,        "OriginalSubject" },
            {(PropertyCanonicalName)0x004c,        "OriginalAuthorEntryId" },
            {(PropertyCanonicalName)0x004d,        "OriginalAuthorName" },
            {(PropertyCanonicalName)0x004e,        "OriginalSubmitTime" },
            {(PropertyCanonicalName)0x004f,        "ReplyRecipientEntries" },
            {(PropertyCanonicalName)0x0050,        "ReplyRecipientNames" },
            {(PropertyCanonicalName)0x0051,        "ReceivedBySearchKey" },
            {(PropertyCanonicalName)0x0052,        "ReceivedRepresentingSearchKey" },
            {(PropertyCanonicalName)0x0053,        "ReadReceiptSearchKey" },
            {(PropertyCanonicalName)0x0056,        "OriginalAuthorSearchKey" },
            {(PropertyCanonicalName)0x0057,        "MessageToMe" },
            {(PropertyCanonicalName)0x0058,        "MessageCcMe" },
            {(PropertyCanonicalName)0x0059,        "MessageRecipientMe" },
            {(PropertyCanonicalName)0x005a,        "OriginalSenderName" },
            {(PropertyCanonicalName)0x005b,        "OriginalSenderEntryId" },
            {(PropertyCanonicalName)0x005c,        "OriginalSenderSearchKey" },
            {(PropertyCanonicalName)0x005d,        "OriginalSentRepresentingName" },
            {(PropertyCanonicalName)0x005e,        "OriginalSentRepresentingEntryId" },
            {(PropertyCanonicalName)0x005f,        "OriginalSentRepresentingSearchKey" },
            {(PropertyCanonicalName)0x0060,        "StartDate" },
            {(PropertyCanonicalName)0x0061,        "EndDate" },
            {(PropertyCanonicalName)0x0062,        "OwnerAppointmentId" },
            {(PropertyCanonicalName)0x0063,        "ResponseRequested" },
            {(PropertyCanonicalName)0x0064,        "SentRepresentingAddressType" },
            {PropertyCanonicalName.PidTagSentRepresentingEmailAddress, "SentRepresentingEmailAddress" },
            {(PropertyCanonicalName)0x0066,        "OriginalSenderAddressType" },
            {(PropertyCanonicalName)0x0067,        "OriginalSenderEmailAddress" },
            {(PropertyCanonicalName)0x0068,        "OriginalSentRepresentingAddressType" },
            {(PropertyCanonicalName)0x0069,        "OriginalSentRepresentingEmailAddress" },
            {(PropertyCanonicalName)0x0070,        "ConversationTopic" },
            {(PropertyCanonicalName)0x0071,        "ConversationIndex" },
            {(PropertyCanonicalName)0x0072,        "OriginalDisplayBcc" },
            {(PropertyCanonicalName)0x0073,        "OriginalDisplayCc" },
            {(PropertyCanonicalName)0x0074,        "OriginalDisplayTo" },
            {(PropertyCanonicalName)0x0075,        "ReceivedByAddressType" },
            {(PropertyCanonicalName)0x0076,        "ReceivedByEmailAddress" },
            {(PropertyCanonicalName)0x0077,        "ReceivedRepresentingAddressType" },
            {(PropertyCanonicalName)0x0078,        "ReceivedRepresentingEmailAddress" },
            {(PropertyCanonicalName)0x0079,        "OriginalAuthorAddressType" },
            {(PropertyCanonicalName)0x007a,        "OriginalAuthorEmailAddress" },
            {(PropertyCanonicalName)0x007d,        "TransportMessageHeaders" },
            {(PropertyCanonicalName)0x007f,        "TnefCorrelationKey" },
            {(PropertyCanonicalName)0x0080,        "ReportDisposition" },
            {(PropertyCanonicalName)0x0081,        "ReportDispositionModv" },
            {(PropertyCanonicalName)0x0083,        "ReportDispositionToNames" },
            {(PropertyCanonicalName)0x0084,        "ReportDispositionToEmailAddresses" },
            {(PropertyCanonicalName)0x0085,        "ReportDispositionOptions" },
            {(PropertyCanonicalName)0x0086,        "undocumented" },
            {(PropertyCanonicalName)0x0c04,        "NonDeliveryReportReasonCode" },
            {(PropertyCanonicalName)0x0c05,        "NonDeliveryReportDiagCode" },
            {(PropertyCanonicalName)0x0c06,        "NonReceiptNotificationRequested" },
            {(PropertyCanonicalName)0x0c08,        "OriginatorNonDeliveryReportRequested" },
            {(PropertyCanonicalName)0x0c09,        "undocumented" },
            {(PropertyCanonicalName)0x0c15,        "RecipientType" },
            {(PropertyCanonicalName)0x0c17,        "ReplyRequested" },
            {(PropertyCanonicalName)0x0c19,        "SenderEntryId" },
            {PropertyCanonicalName.PidTagSenderName, "SenderName" },
            {(PropertyCanonicalName)0x0c1d,        "SenderSearchKey" },
            {(PropertyCanonicalName)0x0c1e,        "SenderAddressType" },
            {(PropertyCanonicalName)0x0c1f,        "SenderEmailAddress" },
            {(PropertyCanonicalName)0x0c24,        "undocumented" },
            {(PropertyCanonicalName)0x0c25,        "undocumented" },
            {(PropertyCanonicalName)0x0e01,        "DeleteAfterSubmit" },
            {(PropertyCanonicalName)0x0e02,        "DisplayBcc" },
            {(PropertyCanonicalName)0x0e03,        "DisplayCc" },
            {PropertyCanonicalName.PidTagDisplayTo, "DisplayTo" },
            {(PropertyCanonicalName)0x0e05,        "ParentDisplay" },
            {(PropertyCanonicalName)0x0e06,        "MessageDeliveryTime" },
            {(PropertyCanonicalName)0x0e07,        "MessageFlags" },
            {(PropertyCanonicalName)0x0e08,        "MessageSize" },
            {(PropertyCanonicalName)0x0e0a,        "SentMailEntryId" },
            {(PropertyCanonicalName)0x0e0f,        "Responsibility" },
            {(PropertyCanonicalName)0x0e14,        "SubmitFlags" },
            {(PropertyCanonicalName)0x0e17,        "MessageStatus" },
            {(PropertyCanonicalName)0x0e1d,        "NormalizedSubject" },
            {(PropertyCanonicalName)0x0e1f,        "RtfInSync" },
            {PropertyCanonicalName.PidTagAttachSize, "AttachSize" },
            {(PropertyCanonicalName)0x0e23,        "InternetArticleNumber" },
            {(PropertyCanonicalName)0x0e27,        "undocumented" },
            {(PropertyCanonicalName)0x0e28,        "PrimarySendAccount" },
            {(PropertyCanonicalName)0x0e29,        "NextSendAcct" },
            {(PropertyCanonicalName)0x0e2b,        "ToDoItemFlags" },
            {(PropertyCanonicalName)0x0e2f,        "undocumented" },
            {(PropertyCanonicalName)0x0e30,        "undocumented" },
            {(PropertyCanonicalName)0x0e32,        "undocumented" },
            {(PropertyCanonicalName)0x0e33,        "undocumented" },
            {(PropertyCanonicalName)0x0e34,        "undocumented" },
            {(PropertyCanonicalName)0x0e46,        "undocumented" },
            {(PropertyCanonicalName)0x0e48,        "undocumented" },
            {(PropertyCanonicalName)0x0e4b,        "undocumented" },
            {(PropertyCanonicalName)0x0e4c,        "undocumented" },
            {(PropertyCanonicalName)0x0e4d,        "undocumented" },
            {(PropertyCanonicalName)0x0e4e,        "undocumented" },
            {(PropertyCanonicalName)0x0e53,        "undocumented" },
            {(PropertyCanonicalName)0x0e55,        "undocumented" },
            {(PropertyCanonicalName)0x0e58,        "undocumented" },
            {(PropertyCanonicalName)0x0e59,        "undocumented" },
            {(PropertyCanonicalName)0x0e62,        "undocumented" },
            {(PropertyCanonicalName)0x0e79,        "TrustSender" },
            {(PropertyCanonicalName)0x0e92,        "undocumented" },
            {(PropertyCanonicalName)0x0e93,        "undocumented" },
            {(PropertyCanonicalName)0x0e9d,        "undocumented" },
            {(PropertyCanonicalName)0x0ecd,        "undocumented" },
            {(PropertyCanonicalName)0x0f01,        "undocumented" },
            {(PropertyCanonicalName)0x0f02,        "undocumented" },
            {(PropertyCanonicalName)0x0f03,        "undocumented" },
            {(PropertyCanonicalName)0x0f0a,        "undocumented" },
            {(PropertyCanonicalName)0x0ff7,        "AccessLevel" },
            {(PropertyCanonicalName)0x0ff9,        "RecordKey" },
            {(PropertyCanonicalName)0x0ffe,        "ObjectType" },
            {(PropertyCanonicalName)0x0fff,        "EntryId" },
            {(PropertyCanonicalName)0x1001,        "ReportText" },
            {(PropertyCanonicalName)0x1015,        "BodyContentId" },
            {(PropertyCanonicalName)0x1033,        "undocumented" },
            {(PropertyCanonicalName)0x1034,        "undocumented" },
            {(PropertyCanonicalName)0x1035,        "InternetMessageId" },
            {(PropertyCanonicalName)0x1037,        "undocumented" },
            {(PropertyCanonicalName)0x1038,        "undocumented" },
            {(PropertyCanonicalName)0x1039,        "InternetReferences" },
            {(PropertyCanonicalName)0x1040,        "undocumented" },
            {(PropertyCanonicalName)0x1042,        "InReplyToId" },
            {(PropertyCanonicalName)0x1044,        "ListSubscribe" },
            {(PropertyCanonicalName)0x1045,        "ListUnsubscribe" },
            {(PropertyCanonicalName)0x1046,        "InternetReturnPath" },
            {(PropertyCanonicalName)0x1080,        "IconIndex" },
            {(PropertyCanonicalName)0x1081,        "LastVerbExecuted" },
            {(PropertyCanonicalName)0x1082,        "LastVerbExecutionTime" },
            {(PropertyCanonicalName)0x1043,        "ListHelp" },
            {(PropertyCanonicalName)0x1090,        "FlagStatus" },
            {(PropertyCanonicalName)0x1091,        "FlagCompleteTime" },
            {(PropertyCanonicalName)0x1092,        "undocumented" },
            {(PropertyCanonicalName)0x1095,        "FollowupIcon" },
            {(PropertyCanonicalName)0x1096,        "BlockStatus" },
            {(PropertyCanonicalName)0x10f3,        "undocumented" },
            {(PropertyCanonicalName)0x10f4,        "AttributeHidden" },
            {(PropertyCanonicalName)0x10f5,        "undocumented" },
            {(PropertyCanonicalName)0x10f6,        "AttributeReadOnly" },
            {(PropertyCanonicalName)0x1204,        "undocumented" },
            {(PropertyCanonicalName)0x1205,        "undocumented" },
            {(PropertyCanonicalName)0x1206,        "undocumented" },
            {(PropertyCanonicalName)0x120b,        "undocumented" },
            {(PropertyCanonicalName)0x1212,        "undocumented" },
            {(PropertyCanonicalName)0x1213,        "undocumented" },
            {PropertyCanonicalName.PidTagDisplayName, "DisplayName" },
            {(PropertyCanonicalName)0x3002,        "AddressType" },
            {(PropertyCanonicalName)0x3003,        "EmailAddress" },
            {(PropertyCanonicalName)0x3004,        "Comment" },
            {(PropertyCanonicalName)0x3007,        "CreationTime" },
            {(PropertyCanonicalName)0x3008,        "LastModificationTime" },
            {(PropertyCanonicalName)0x300b,        "SearchKey" },
            {(PropertyCanonicalName)0x300f,        "undocumented" },
            {(PropertyCanonicalName)0x3010,        "TargetEntryId" },
            {(PropertyCanonicalName)0x3014,        "undocumented" },
            {(PropertyCanonicalName)0x3016,        "ConversationIndexTracking" },
            {(PropertyCanonicalName)0x3019,        "PolicyTag" },
            {(PropertyCanonicalName)0x301b,        "StartDateEtc" },
            {(PropertyCanonicalName)0x301c,        "RetentionDate" },
            {(PropertyCanonicalName)0x301d,        "RetentionFlags" },
            {(PropertyCanonicalName)0x348a,        "undocumented" },
            {(PropertyCanonicalName)0x3702,        "AttachEncoding" },
            {(PropertyCanonicalName)0x3703,        "AttachExtension" },
            {PropertyCanonicalName.PidTagAttachFilename, "AttachFilename" },
            {PropertyCanonicalName.PidTagAttachMethod, "AttachMethod" },
            {PropertyCanonicalName.PidTagAttachLongFilename, "AttachLongFilename" },
            {(PropertyCanonicalName)0x3708,        "AttachPathname" },
            {(PropertyCanonicalName)0x3709,        "AttachRendering" },
            {(PropertyCanonicalName)0x370a,        "AttachTag" },
            {(PropertyCanonicalName)0x370b,        "RenderingPosition" },
            {(PropertyCanonicalName)0x370d,        "AttachLongPathname" },
            {PropertyCanonicalName.PidTagAttachMimeTag, "AttachMimeTag" },
            {(PropertyCanonicalName)0x3710,        "undocumented" },
            {(PropertyCanonicalName)0x3711,        "AttachContentBase" },
            {PropertyCanonicalName.PidTagAttachContentId, "AttachContentId" },
            {(PropertyCanonicalName)0x3713,        "AttachContentLocation" },
            {PropertyCanonicalName.PidTagAttachFlags, "AttachFlags" },
            {(PropertyCanonicalName)0x371d,        "undocumented" },
            {(PropertyCanonicalName)0x3900,        "DisplayType" },
            {(PropertyCanonicalName)0x3905,        "DisplayTypeEx" },
            {(PropertyCanonicalName)0x39fe,        "SmtpAddress" },
            {(PropertyCanonicalName)0x39ff,        "AddressBookDisplayNamePrintable" },
            {(PropertyCanonicalName)0x3a00,        "Account" },
            {(PropertyCanonicalName)0x3a02,        "CallbackTelephoneNumber" },
            {(PropertyCanonicalName)0x3a05,        "Generation" },
            {(PropertyCanonicalName)0x3a06,        "GivenName" },
            {(PropertyCanonicalName)0x3a08,        "BusinessTelephoneNumber" },
            {(PropertyCanonicalName)0x3a09,        "HomeTelephoneNumber" },
            {(PropertyCanonicalName)0x3a0a,        "Initials" },
            {(PropertyCanonicalName)0x3a0b,        "Keyword" },
            {(PropertyCanonicalName)0x3a0c,        "Language" },
            {(PropertyCanonicalName)0x3a0d,        "Location" },
            {(PropertyCanonicalName)0x3a11,        "Surname" },
            {(PropertyCanonicalName)0x3a12,        "OriginalEntryId" },
            {(PropertyCanonicalName)0x3a13,        "undocumented" },
            {(PropertyCanonicalName)0x3a14,        "undocumented" },
            {(PropertyCanonicalName)0x3a16,        "CompanyName" },
            {(PropertyCanonicalName)0x3a17,        "Title" },
            {(PropertyCanonicalName)0x3a18,        "DepartmentName" },
            {(PropertyCanonicalName)0x3a1a,        "PrimaryTelephoneNumber" },
            {(PropertyCanonicalName)0x3a1b,        "Business2TelephoneNumber" },
            {(PropertyCanonicalName)0x3a1c,        "MobileTelephoneNumber" },
            {(PropertyCanonicalName)0x3a1d,        "RadioTelephoneNumber" },
            {(PropertyCanonicalName)0x3a1e,        "CarTelephoneNumber" },
            {(PropertyCanonicalName)0x3a1f,        "OtherTelephoneNumber" },
            {(PropertyCanonicalName)0x3a20,        "TransmittableDisplayName" },
            {(PropertyCanonicalName)0x3a21,        "PagerTelephoneNumber" },
            {(PropertyCanonicalName)0x3a23,        "PrimaryFaxNumber" },
            {(PropertyCanonicalName)0x3a24,        "BusinessFaxNumber" },
            {(PropertyCanonicalName)0x3a25,        "HomeFaxNumber" },
            {(PropertyCanonicalName)0x3a26,        "Country" },
            {(PropertyCanonicalName)0x3a27,        "Locality" },
            {(PropertyCanonicalName)0x3a28,        "StateOrProvince" },
            {(PropertyCanonicalName)0x3a2c,        "TelexNumber" },
            {(PropertyCanonicalName)0x3a2d,        "IsdnNumber" },
            {(PropertyCanonicalName)0x3a2e,        "AssistantTelephoneNumber" },
            {(PropertyCanonicalName)0x3a2f,        "Home2TelephoneNumber" },
            {(PropertyCanonicalName)0x3a40,        "SendRichInfo" },
            {(PropertyCanonicalName)0x3a42,        "Birthday" },
            {(PropertyCanonicalName)0x3a44,        "MiddleName" },
            {(PropertyCanonicalName)0x3a45,        "DisplayNamePrefix" },
            {(PropertyCanonicalName)0x3a4b,        "TelecommunicationsDeviceForDeafTelephoneNumber" },
            {(PropertyCanonicalName)0x3a4f,        "Nickname" },
            {(PropertyCanonicalName)0x3a50,        "PersonalHomePage" },
            {(PropertyCanonicalName)0x3a51,        "BusinessHomePage" },
            {(PropertyCanonicalName)0x3a57,        "CompanyMainTelephoneNumber" },
            {(PropertyCanonicalName)0x3a59,        "HomeAddressCity" },
            {(PropertyCanonicalName)0x3a5a,        "HomeAddressCountry" },
            {(PropertyCanonicalName)0x3a5b,        "HomeAddressPostalCode" },
            {(PropertyCanonicalName)0x3a5c,        "HomeAddresssStateOrProvince" },
            {(PropertyCanonicalName)0x3a5d,        "HomeAddressStreet" },
            {(PropertyCanonicalName)0x3a71,        "SendInternetEncoding" },
            {(PropertyCanonicalName)0x3a76,        "undocumented" },
            {(PropertyCanonicalName)0x3a77,        "undocumented" },
            {(PropertyCanonicalName)0x3a78,        "undocumented" },
            {(PropertyCanonicalName)0x3a79,        "undocumented" },
            {(PropertyCanonicalName)0x3d01,        "undocumented" },
            {(PropertyCanonicalName)0x3fd9,        "undocumented" },
            {(PropertyCanonicalName)0x3fde,        "InternetCodepage" },
            {(PropertyCanonicalName)0x3fdf,        "AutoResponseSuppress" },
            {(PropertyCanonicalName)0x3fea,        "HasDeferredActionMessages" },
            {(PropertyCanonicalName)0x3fef,        "DeferredSendTime" },
            {(PropertyCanonicalName)0x3ff1,        "MessageLocaleId" },
            {(PropertyCanonicalName)0x3ff2,        "undocumented" },
            {(PropertyCanonicalName)0x3ff8,        "CreatorName" },
            {(PropertyCanonicalName)0x3ff9,        "CreatorEntryId" },
            {(PropertyCanonicalName)0x3ffa,        "LastModifierName" },
            {(PropertyCanonicalName)0x3ffb,        "LastModifierEntryId" },
            {(PropertyCanonicalName)0x3ffd,        "MessageCodepage" },
            {(PropertyCanonicalName)0x4019,        "SenderFlags" },
            {(PropertyCanonicalName)0x401a,        "SentRepresentingFlags" },
            {(PropertyCanonicalName)0x401b,        "ReceivedByFlags" },
            {(PropertyCanonicalName)0x401c,        "ReceivedRepresentingFlags" },
            {(PropertyCanonicalName)0x401d,        "undocumented" },
            {(PropertyCanonicalName)0x401e,        "undocumented" },
            {(PropertyCanonicalName)0x4022,        "undocumented" },
            {(PropertyCanonicalName)0x4023,        "undocumented" },
            {(PropertyCanonicalName)0x4024,        "undocumented" },
            {(PropertyCanonicalName)0x4025,        "undocumented" },
            {(PropertyCanonicalName)0x4029,        "ReadReceiptAddressType" },
            {(PropertyCanonicalName)0x402a,        "ReadReceiptEmailAddress" },
            {(PropertyCanonicalName)0x402b,        "ReadReceiptName" },
            {(PropertyCanonicalName)0x4030,        "SenderSimpleDisplayName" },
            {(PropertyCanonicalName)0x4031,        "SentRepresentingSimpleDisplayName" },
            {(PropertyCanonicalName)0x4034,        "undocumented" },
            {(PropertyCanonicalName)0x4035,        "ReceivedRepresentingSimpleDisplayName" },
            {(PropertyCanonicalName)0x4036,        "undocumented" },
            {(PropertyCanonicalName)0x4038,        "CreatorSimpleDisplayName" },
            {(PropertyCanonicalName)0x4039,        "LastModifierSimpleDisplayName" },
            {(PropertyCanonicalName)0x4059,        "undocumented" },
            {(PropertyCanonicalName)0x405a,        "undocumented" },
            {(PropertyCanonicalName)0x405b,        "undocumented" },
            {(PropertyCanonicalName)0x405d,        "undocumented" },
            {(PropertyCanonicalName)0x405e,        "undocumented" },
            {(PropertyCanonicalName)0x4060,        "undocumented" },
            {(PropertyCanonicalName)0x4076,        "ContentFilterSpamConfidenceLevel" },
            {(PropertyCanonicalName)0x4079,        "SenderIdStatus" },
            {(PropertyCanonicalName)0x4080,        "undocumented" },
            {(PropertyCanonicalName)0x4084,        "undocumented" },
            {(PropertyCanonicalName)0x5902,        "InternetMailOverrideFormat" },
            {(PropertyCanonicalName)0x5909,        "MessageEditorFormat" },
            {(PropertyCanonicalName)0x5d01,        "SenderSmtpAddress" },
            {(PropertyCanonicalName)0x5d02,        "SentRepresentingSmtpAddress" },
            {(PropertyCanonicalName)0x5d05,        "ReadReceiptSmtpAddress" },
            {(PropertyCanonicalName)0x5d06,        "undocumented" },
            {(PropertyCanonicalName)0x5d07,        "ReceivedBySmtpAddress" },
            {(PropertyCanonicalName)0x5d08,        "ReceivedRepresentingSmtpAddress" },
            {(PropertyCanonicalName)0x5d09,        "undocumented" },
            {(PropertyCanonicalName)0x5fde,        "undocumented" },
            {(PropertyCanonicalName)0x5fdf,        "RecipientOrder" },
            {(PropertyCanonicalName)0x5fe5,        "undocumented" },
            {(PropertyCanonicalName)0x5feb,        "undocumented" },
            {(PropertyCanonicalName)0x5fef,        "undocumented" },
            {(PropertyCanonicalName)0x5ff2,        "undocumented" },
            {(PropertyCanonicalName)0x5ff5,        "undocumented" },
            {(PropertyCanonicalName)0x5ff6,        "RecipientDisplayName" },
            {(PropertyCanonicalName)0x5ff7,        "RecipientEntryId" },
            {(PropertyCanonicalName)0x5ffd,        "RecipientFlags" },
            {(PropertyCanonicalName)0x5fff,        "RecipientTrackStatus" },
            {(PropertyCanonicalName)0x6001,        "undocumented" },
            {(PropertyCanonicalName)0x6200,        "undocumented" },
            {(PropertyCanonicalName)0x6201,        "undocumented" },
            {(PropertyCanonicalName)0x65c6,        "SecureSubmitFlags" },
            {(PropertyCanonicalName)0x65e0,        "SourceKey" },
            {(PropertyCanonicalName)0x65e1,        "ParentSourceKey" },
            {(PropertyCanonicalName)0x65e2,        "ChangeKey" },
            {(PropertyCanonicalName)0x65e3,        "PredecessorChangeList" },
            {(PropertyCanonicalName)0x65f5,        "undocumented" },
            {(PropertyCanonicalName)0x6604,        "undocumented" },
            {(PropertyCanonicalName)0x6610,        "undocumented" },
            {(PropertyCanonicalName)0x6619,        "UserEntryId" },
            {(PropertyCanonicalName)0x661a,        "undocumented" },
            {(PropertyCanonicalName)0x66a8,        "FolderFlags" },
            {(PropertyCanonicalName)0x66aa,        "undocumented" },
            {(PropertyCanonicalName)0x66b9,        "undocumented" },
            {(PropertyCanonicalName)0x66ca,        "undocumented" },
            {(PropertyCanonicalName)0x6743,        "undocumented" },
            {(PropertyCanonicalName)0x67f2,        "undocumented" },
            {(PropertyCanonicalName)0x67f3,        "undocumented" },
            {(PropertyCanonicalName)0x67f4,        "undocumented" },
            {(PropertyCanonicalName)0x6801,        "OfflineAddressBookSequence" },
            {(PropertyCanonicalName)0x6802,        "RwRulesStream" },
            {(PropertyCanonicalName)0x6804,        "FaxNumberOfPages" },
            {(PropertyCanonicalName)0x6805,        "OfflineAddressBookTruncatedProperties" },
            {(PropertyCanonicalName)0x6814,        "undocumented" },
            {(PropertyCanonicalName)0x6820,        "ReportingMessageTransferAgent" },
            {(PropertyCanonicalName)0x6884,        "undocumented" },
            {(PropertyCanonicalName)0x688c,        "undocumented" },
            {(PropertyCanonicalName)0x688d,        "undocumented" },
            {(PropertyCanonicalName)0x6899,        "undocumented" },
            {(PropertyCanonicalName)0x689b,        "undocumented" },
            {(PropertyCanonicalName)0x689e,        "undocumented" },
            {(PropertyCanonicalName)0x68a1,        "undocumented" },
            {(PropertyCanonicalName)0x68a6,        "undocumented" },
            {(PropertyCanonicalName)0x68a7,        "undocumented" },
            {(PropertyCanonicalName)0x68a8,        "undocumented" },
            {(PropertyCanonicalName)0x68aa,        "undocumented" },
            {(PropertyCanonicalName)0x68b2,        "undocumented" },
            {(PropertyCanonicalName)0x68b9,        "undocumented" },
            {(PropertyCanonicalName)0x68c7,        "undocumented" },
            {(PropertyCanonicalName)0x68da,        "undocumented" },
            {(PropertyCanonicalName)0x7d01,        "undocumented" },
            {(PropertyCanonicalName)0x7ffa,        "AttachmentLinkId" },
            {(PropertyCanonicalName)0x7ffb,        "ExceptionStartTime" },
            {(PropertyCanonicalName)0x7ffc,        "ExceptionEndTime" },
            {(PropertyCanonicalName)0x7ffd,        "AttachmentFlags" },
            {PropertyCanonicalName.PidTagAttachmentHidden, "AttachmentHidden" },
            {(PropertyCanonicalName)0x7fff,        "AttachmentContactPhoto" },
         };

    }
}
