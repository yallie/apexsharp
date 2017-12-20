namespace Demo.SObjects
{
	using Apex.System;
	

	public class User : SObject
	{
		public string Username {set;get;}
		public string LastName {set;get;}
		public string FirstName {set;get;}
		public string Name {set;get;}
		public string CompanyName {set;get;}
		public string Division {set;get;}
		public string Department {set;get;}
		public string Title {set;get;}
		public string Street {set;get;}
		public string City {set;get;}
		public string State {set;get;}
		public string PostalCode {set;get;}
		public string Country {set;get;}
		public double Latitude {set;get;}
		public double Longitude {set;get;}
		public string GeocodeAccuracy {set;get;}
		public Address Address {set;get;}
		public string Email {set;get;}
		public bool EmailPreferencesAutoBcc {set;get;}
		public bool EmailPreferencesAutoBccStayInTouch {set;get;}
		public bool EmailPreferencesStayInTouchReminder {set;get;}
		public string SenderEmail {set;get;}
		public string SenderName {set;get;}
		public string Signature {set;get;}
		public string StayInTouchSubject {set;get;}
		public string StayInTouchSignature {set;get;}
		public string StayInTouchNote {set;get;}
		public string Phone {set;get;}
		public string Fax {set;get;}
		public string MobilePhone {set;get;}
		public string Alias {set;get;}
		public string CommunityNickname {set;get;}
		public string BadgeText {set;get;}
		public bool IsActive {set;get;}
		public string TimeZoneSidKey {set;get;}
		public string UserRoleId {set;get;}
		public UserRole UserRole {set;get;}
		public string LocaleSidKey {set;get;}
		public bool ReceivesInfoEmails {set;get;}
		public bool ReceivesAdminInfoEmails {set;get;}
		public string EmailEncodingKey {set;get;}
		public string ProfileId {set;get;}
		public Profile Profile {set;get;}
		public string UserType {set;get;}
		public string LanguageLocaleKey {set;get;}
		public string EmployeeNumber {set;get;}
		public string DelegatedApproverId {set;get;}
		public string ManagerId {set;get;}
		public User Manager {set;get;}
		public DateTime LastLoginDate {set;get;}
		public DateTime LastPasswordChangeDate {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public DateTime OfflineTrialExpirationDate {set;get;}
		public DateTime OfflinePdaTrialExpirationDate {set;get;}
		public bool UserPermissionsMarketingUser {set;get;}
		public bool UserPermissionsOfflineUser {set;get;}
		public bool UserPermissionsAvantgoUser {set;get;}
		public bool UserPermissionsCallCenterAutoLogin {set;get;}
		public bool UserPermissionsMobileUser {set;get;}
		public bool UserPermissionsSFContentUser {set;get;}
		public bool UserPermissionsInteractionUser {set;get;}
		public bool ForecastEnabled {set;get;}
		public bool UserPreferencesActivityRemindersPopup {set;get;}
		public bool UserPreferencesEventRemindersCheckboxDefault {set;get;}
		public bool UserPreferencesTaskRemindersCheckboxDefault {set;get;}
		public bool UserPreferencesReminderSoundOff {set;get;}
		public bool UserPreferencesDisableAllFeedsEmail {set;get;}
		public bool UserPreferencesDisableFollowersEmail {set;get;}
		public bool UserPreferencesDisableProfilePostEmail {set;get;}
		public bool UserPreferencesDisableChangeCommentEmail {set;get;}
		public bool UserPreferencesDisableLaterCommentEmail {set;get;}
		public bool UserPreferencesDisProfPostCommentEmail {set;get;}
		public bool UserPreferencesContentNoEmail {set;get;}
		public bool UserPreferencesContentEmailAsAndWhen {set;get;}
		public bool UserPreferencesApexPagesDeveloperMode {set;get;}
		public bool UserPreferencesHideCSNGetChatterMobileTask {set;get;}
		public bool UserPreferencesDisableMentionsPostEmail {set;get;}
		public bool UserPreferencesDisMentionsCommentEmail {set;get;}
		public bool UserPreferencesHideCSNDesktopTask {set;get;}
		public bool UserPreferencesHideChatterOnboardingSplash {set;get;}
		public bool UserPreferencesHideSecondChatterOnboardingSplash {set;get;}
		public bool UserPreferencesDisCommentAfterLikeEmail {set;get;}
		public bool UserPreferencesDisableLikeEmail {set;get;}
		public bool UserPreferencesSortFeedByComment {set;get;}
		public bool UserPreferencesDisableMessageEmail {set;get;}
		public bool UserPreferencesDisableBookmarkEmail {set;get;}
		public bool UserPreferencesDisableSharePostEmail {set;get;}
		public bool UserPreferencesEnableAutoSubForFeeds {set;get;}
		public bool UserPreferencesDisableFileShareNotificationsForApi {set;get;}
		public bool UserPreferencesShowTitleToExternalUsers {set;get;}
		public bool UserPreferencesShowManagerToExternalUsers {set;get;}
		public bool UserPreferencesShowEmailToExternalUsers {set;get;}
		public bool UserPreferencesShowWorkPhoneToExternalUsers {set;get;}
		public bool UserPreferencesShowMobilePhoneToExternalUsers {set;get;}
		public bool UserPreferencesShowFaxToExternalUsers {set;get;}
		public bool UserPreferencesShowStreetAddressToExternalUsers {set;get;}
		public bool UserPreferencesShowCityToExternalUsers {set;get;}
		public bool UserPreferencesShowStateToExternalUsers {set;get;}
		public bool UserPreferencesShowPostalCodeToExternalUsers {set;get;}
		public bool UserPreferencesShowCountryToExternalUsers {set;get;}
		public bool UserPreferencesShowProfilePicToGuestUsers {set;get;}
		public bool UserPreferencesShowTitleToGuestUsers {set;get;}
		public bool UserPreferencesShowCityToGuestUsers {set;get;}
		public bool UserPreferencesShowStateToGuestUsers {set;get;}
		public bool UserPreferencesShowPostalCodeToGuestUsers {set;get;}
		public bool UserPreferencesShowCountryToGuestUsers {set;get;}
		public bool UserPreferencesHideS1BrowserUI {set;get;}
		public bool UserPreferencesDisableEndorsementEmail {set;get;}
		public bool UserPreferencesPathAssistantCollapsed {set;get;}
		public bool UserPreferencesCacheDiagnostics {set;get;}
		public bool UserPreferencesShowEmailToGuestUsers {set;get;}
		public bool UserPreferencesShowManagerToGuestUsers {set;get;}
		public bool UserPreferencesShowWorkPhoneToGuestUsers {set;get;}
		public bool UserPreferencesShowMobilePhoneToGuestUsers {set;get;}
		public bool UserPreferencesShowFaxToGuestUsers {set;get;}
		public bool UserPreferencesShowStreetAddressToGuestUsers {set;get;}
		public bool UserPreferencesLightningExperiencePreferred {set;get;}
		public bool UserPreferencesPreviewLightning {set;get;}
		public bool UserPreferencesHideEndUserOnboardingAssistantModal {set;get;}
		public bool UserPreferencesHideLightningMigrationModal {set;get;}
		public bool UserPreferencesHideSfxWelcomeMat {set;get;}
		public bool UserPreferencesHideBiggerPhotoCallout {set;get;}
		public bool UserPreferencesGlobalNavBarWTShown {set;get;}
		public bool UserPreferencesGlobalNavGridMenuWTShown {set;get;}
		public bool UserPreferencesCreateLEXAppsWTShown {set;get;}
		public bool UserPreferencesFavoritesWTShown {set;get;}
		public bool UserPreferencesRecordHomeSectionCollapseWTShown {set;get;}
		public bool UserPreferencesRecordHomeReservedWTShown {set;get;}
		public bool UserPreferencesFavoritesShowTopFavorites {set;get;}
		public string ContactId {set;get;}
		public Contact Contact {set;get;}
		public string AccountId {set;get;}
		public Account Account {set;get;}
		public string CallCenterId {set;get;}
		public string Extension {set;get;}
		public string FederationIdentifier {set;get;}
		public string AboutMe {set;get;}
		public string FullPhotoUrl {set;get;}
		public string SmallPhotoUrl {set;get;}
		public bool IsExtIndicatorVisible {set;get;}
		public string MediumPhotoUrl {set;get;}
		public string DigestFrequency {set;get;}
		public string DefaultGroupNotificationFrequency {set;get;}
		public DateTime LastViewedDate {set;get;}
		public DateTime LastReferencedDate {set;get;}
		public string BannerPhotoUrl {set;get;}
		public string SmallBannerPhotoUrl {set;get;}
		public string MediumBannerPhotoUrl {set;get;}
		public bool IsProfilePhotoActive {set;get;}
	}
}
