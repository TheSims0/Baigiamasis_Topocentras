# Baigiamasis_Topocentras        

![Logotipas (1) (1)](https://github.com/TheSims0/Baigiamasis_Topocentras/assets/128743352/92917a0a-0717-4240-b66d-8f15294d7fe4)

Final assignment for VCSA

Page chosen to test [Topo Centras](https://www.topocentras.lt/)   
## Test scenarios and test cases
### TS01: Login

- **TC01:** Login using valid data"
  - **TC01.01:** Click "prisijungti'
  - **TC01.02:** Enter a valid email
  - **TC01.03:** Enter a valid password
  - **TC01.04:** Click "prisijungti"
  - **TC01.05:** Click "mano paskyra"
  - **TC01.06:** Check if greeting message is displayed

### TS02: Add products to cart

- **TC01:** Add four unique products to cart
  - **TC01.01:** Click "buitine technika"
  - **TC01.02:** Click "kaitlentės"
  - **TC01.03:** Click "į krepšelį" on a product
  - **TC01.04:** Close the pop up menu
  - **TC01.05:** Repeat steps 3-4 for 3 more products
  - **TC01.06:** Click "Krepšelis"
  - **TC01.07:** Check if all four products are displayed

### TS03: Comparing products

- **TC01:** Compare unique products
  - **TC01.01:** Click "žaidimų erdvė"
  - **TC01.02:** Click "žaidimų monitoriai"
  - **TC01.03:** Click "palyginti" on a product
  - **TC01.04:** Repeat steps 2-3 for 2 more products
  - **TC01.05:** Click "palyginti" on the bottom menu
  - **TC01.06:** Check if all three products are unique

### TS04: Leaving a review

- **TC01:** Leaving a review for a product
  - **TC01.01:** Click "televizoriai"
  - **TC01.02:** Click "LG televizoriai"
  - **TC01.03:** Click on the first product
  - **TC01.04:** Click "rašyti apžvalgą"
  - **TC01.05:** Fill out the form with valid data
  - **TC01.06:** Click "Pateikti atsiliepimą"
  - **TC01.07:** Check if "Jūsų apžvalga pateikta!" message is displayed

### TS05: Buying a product

- **TC01:** Buying a product while logged in
  - **TC01.01:** Click "telefonai"
  - **TC01.02:** Click "OnePlus"
  - **TC01.03:** Click on the first product
  - **TC01.04:** Click "Į krepšelį"
  - **TC01.05:** Click "Pirkti"
  - **TC01.06:** Click "Pirkti" at the bottom
  - **TC01.07:** Click "Prisijungti" and login using valid data
  - **TC01.08:** Fill the form with valid data and click "Toliau"
  - **TC01.09:** Select city and shop and click "Toliau"
  - **TC01.10:** Select payment method and click "Toliau"
  - **TC01.11:** Check if final menu is reached before payment and "Patvirtinti užsakymą" is displayed
