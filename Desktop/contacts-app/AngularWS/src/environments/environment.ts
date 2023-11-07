interface Environment {
  production: boolean;
  apiUri: string;
}

export const environment: Environment = {
  production: false,
  apiUri: 'http://localhost:3000/api/v1'
};
