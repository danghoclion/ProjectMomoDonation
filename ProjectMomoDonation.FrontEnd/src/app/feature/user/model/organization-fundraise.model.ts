export interface OrganizationFundraiseModel {
  organizationFundraiseId: number;
  urlSlug: string;
  name: string;
  shortName: string;
  description: string;
  avatar: string;
  image: string;
  programDonations: any | null;
}
