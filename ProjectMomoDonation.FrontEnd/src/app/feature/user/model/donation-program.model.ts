export interface DonationProgramModel {
  id: number;
  title: string;
  avatarUrl: string;
  urlSlug: string;
  shortTitle: string;
  story: string;
  dateStart: string;
  dateEnd: string;
  totalDonate: number;
  donationGoal: number;
  status: string;
  categoryId: number;
  organizationFundraiseId: number;
  categoryName: string;
  organizationName: string;
  organizationAvatar: string;
  countDonation: number;
}
