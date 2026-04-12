$replacements = @{
    "index.html" = "/Home/Index"
    "index1.html" = "/Home/Index1"
    "women.html" = "/Home/Women"
    "men.html" = "/Home/Men"
    "kids.html" = "/Home/Kids"
    "shop.html" = "/Home/Shop"
    "product-details.html" = "/Home/ProductDetails"
    "shop-cart.html" = "/Home/ShopCart"
    "checkout.html" = "/Home/Checkout"
    "contact.html" = "/Home/Contact"
    "login.html" = "/Home/Login"
    "signup.html" = "/Home/Signup"
    "dashboard.html" = "/Home/Dashboard"
    "settings.html" = "/Home/Settings"
    "posts.html" = "/Home/Posts"
    "statistics.html" = "/Home/Statistics"
    "users.html" = "/Home/Users"
}

Get-ChildItem -Path "d:\depi_project\backend\backend\Views\Home" -Filter *.cshtml | ForEach-Object {
    $content = Get-Content $_.FullName -Raw
    foreach ($key in $replacements.Keys) {
        $content = [System.Text.RegularExpressions.Regex]::Replace($content, 'href="\.\/?' + $key + '"', 'href="' + $replacements[$key] + '"')
    }
    Set-Content $_.FullName $content
}
