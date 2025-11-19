# Backy Roadmap / TODO List

## System-Level Endpoints (Developer-Facing)
These endpoints are used by developers via the Backy developer dashboard and require System authentication to prevent Project Users from calling them.

### Developer
- [ ] Developer registration
- [ ] Developer login
- [ ] Developer logout
- [ ] Refresh token support
- [ ] Developer email verification
- [ ] Developer password reset
- [ ] Delete Developer account

### Project
- [ ] Create Project
- [ ] Delete Project
- [ ] Get Project list
- [ ] Select Project
- [ ] Get Project Stats
- [ ] Get Project Settings
- [ ] Get Project audit logs
- [ ] Edit allowed origins for CORS
- [ ] Edit JWT configuration
- [ ] Create Project Global Variable (type is chosen by developer. value can only be changed in the developer dashboard)
- [ ] Create Project User Variable (developer chooses the type and initial value. if it stores json data the developer must include the json schema)
- [ ] Create Project Protected User Variable (these can only be changed if the Project User paid for the feature)
- [ ] Create Project Protected Credit Variable (int)
  - Credits updated on purchase
  - Not editable by Project Users
  - Can be purchased with Project Credit Variables (e.g. buy gold with gems) or payment
- [ ] Get Project Users (database view)

### Monetization System
- [ ] Validate Order Webhook (this webhook can used in a payment provider like Stripe. the feature for the order is given to the user)
- [ ] Define subscription tiers (price, duration, features)
- [ ] Define in app Project User Feature (price). Can be purchased with Project Credit Variables or payment

---

## Project-Level Endpoints (Client-Facing)
These APIs are used by applications built on Backy, scoped by each `PublicProjectId`.

### Project User
- [ ] User registration
- [ ] User login
- [ ] User logout
- [ ] Refresh token support
- [ ] User email verification
- [ ] User password reset
- [ ] Delete User account

### Project Variable
- [ ] Update Project User Variable (can only update variables created by the developer)
  - Backy rejects requests that exceed the size limit
- [ ] Update Project Protected User Variable (can only be changed if the Project User purchased the feature required)
  - Backy rejects requests that exceed the size limit
- [ ] Get Project Global Variable
- [ ] Get Project User Variable
- [ ] Get Project Protected User Variable
- [ ] Get Project User Features

### In-App Purchases
- [ ] Create Payment Order (Backy will only create the order if the Project User doesn't own the feature. when this order is validated by the webhook, the feature is given to the Project User)
- [ ] Purchase in app feature with credits (Backy will give the feature if Credit conditions are met)

---

## Internal System
These are features within the Backy system.

### Security
- [ ] Enforce all client-facing APIs with per-project CORS and JWT
- [ ] Rate limiting
- [ ] API quota
- [ ] Abuse detection
- [ ] Developer/Project audit logs
- [ ] API call count per Project
- [ ] Error rate tracking per Project
- [ ] Daily active Project Users tracking
- [ ] Variable size tracking
- [ ] Storage quota tracking
- [ ] Suspend Project
- [ ] Suspend Developer
- [ ] Disable abusive API usage
- [ ] Dashboard (for developers of Backy. not for developers using Backy as a service)


---

## Notes
- System endpoints require Developer authentication and is used on the developer dashboard
- Project endpoints require ProjectUser authentication and is used in a developer's Project
- Public IDs (e.g., `PublicProjectId`) must never expose internal primary keys. Project-Level Endpoints calls must include PublicProjectId instead of Project.Id/ProjectId
- Use the prefix `public` for any properties that are used in a Project frontend
- All client-facing APIs enforce CORS, per-project configuration, and strict validation.
