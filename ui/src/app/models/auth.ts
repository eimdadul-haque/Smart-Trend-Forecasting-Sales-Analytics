
export interface Login {
    userName: string;
    password: string;
}

export interface Register {
    firstName: string;
    lastName: string;
    email: string;
    password: string;
    phoneNumber: string;
    acceptTerms: boolean;
}