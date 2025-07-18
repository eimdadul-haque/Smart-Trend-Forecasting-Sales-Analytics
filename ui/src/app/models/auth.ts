
export interface Login {
    email: string;
    password: string;
    rememberMe: boolean;
}

export interface Register {
    firstName: string;
    lastName: string;
    email: string;
    password: string;
    phoneNumber: string;
    acceptTerms: boolean;
}