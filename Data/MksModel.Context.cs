﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Data
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class MSKEntities : DbContext
{
    public MSKEntities()
        : base("name=MSKEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }



    public virtual ObjectResult<GetSections_Result> GetSections()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSections_Result>("GetSections");
    }


    public virtual ObjectResult<GetUserModules_Result> GetUserModules(Nullable<long> userId)
    {

        var userIdParameter = userId.HasValue ?
            new ObjectParameter("UserId", userId) :
            new ObjectParameter("UserId", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserModules_Result>("GetUserModules", userIdParameter);
    }


    public virtual int UpdateLoginNoPassword(Nullable<long> idLogin, string login, Nullable<long> id_company, string email, string phone)
    {

        var idLoginParameter = idLogin.HasValue ?
            new ObjectParameter("idLogin", idLogin) :
            new ObjectParameter("idLogin", typeof(long));


        var loginParameter = login != null ?
            new ObjectParameter("login", login) :
            new ObjectParameter("login", typeof(string));


        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var emailParameter = email != null ?
            new ObjectParameter("email", email) :
            new ObjectParameter("email", typeof(string));


        var phoneParameter = phone != null ?
            new ObjectParameter("phone", phone) :
            new ObjectParameter("phone", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLoginNoPassword", idLoginParameter, loginParameter, id_companyParameter, emailParameter, phoneParameter);
    }


    public virtual int UpdateLoginPassword(Nullable<long> idLogin, Nullable<long> id_company, Nullable<long> password)
    {

        var idLoginParameter = idLogin.HasValue ?
            new ObjectParameter("idLogin", idLogin) :
            new ObjectParameter("idLogin", typeof(long));


        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var passwordParameter = password.HasValue ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLoginPassword", idLoginParameter, id_companyParameter, passwordParameter);
    }


    public virtual int ups_InsertOrderDetail(Nullable<long> id_company, Nullable<long> id_order, Nullable<long> id_commodity, Nullable<decimal> amount, Nullable<long> id_unit, Nullable<decimal> price, Nullable<bool> nounit)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var id_orderParameter = id_order.HasValue ?
            new ObjectParameter("id_order", id_order) :
            new ObjectParameter("id_order", typeof(long));


        var id_commodityParameter = id_commodity.HasValue ?
            new ObjectParameter("id_commodity", id_commodity) :
            new ObjectParameter("id_commodity", typeof(long));


        var amountParameter = amount.HasValue ?
            new ObjectParameter("amount", amount) :
            new ObjectParameter("amount", typeof(decimal));


        var id_unitParameter = id_unit.HasValue ?
            new ObjectParameter("id_unit", id_unit) :
            new ObjectParameter("id_unit", typeof(long));


        var priceParameter = price.HasValue ?
            new ObjectParameter("price", price) :
            new ObjectParameter("price", typeof(decimal));


        var nounitParameter = nounit.HasValue ?
            new ObjectParameter("nounit", nounit) :
            new ObjectParameter("nounit", typeof(bool));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ups_InsertOrderDetail", id_companyParameter, id_orderParameter, id_commodityParameter, amountParameter, id_unitParameter, priceParameter, nounitParameter);
    }


    public virtual ObjectResult<Nullable<bool>> usp_CheckLogin(string user, string pass)
    {

        var userParameter = user != null ?
            new ObjectParameter("user", user) :
            new ObjectParameter("user", typeof(string));


        var passParameter = pass != null ?
            new ObjectParameter("pass", pass) :
            new ObjectParameter("pass", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("usp_CheckLogin", userParameter, passParameter);
    }


    public virtual ObjectResult<Nullable<bool>> usp_CheckToken(string token)
    {

        var tokenParameter = token != null ?
            new ObjectParameter("token", token) :
            new ObjectParameter("token", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("usp_CheckToken", tokenParameter);
    }


    public virtual int usp_deleteOrder(Nullable<long> idorder)
    {

        var idorderParameter = idorder.HasValue ?
            new ObjectParameter("idorder", idorder) :
            new ObjectParameter("idorder", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_deleteOrder", idorderParameter);
    }


    public virtual ObjectResult<usp_GetAllLogin_Result> usp_GetAllLogin()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllLogin_Result>("usp_GetAllLogin");
    }


    public virtual ObjectResult<usp_GetAllLogins_Result> usp_GetAllLogins(Nullable<long> id_company)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllLogins_Result>("usp_GetAllLogins", id_companyParameter);
    }


    public virtual ObjectResult<Nullable<long>> usp_GetLogin(string user, string pass)
    {

        var userParameter = user != null ?
            new ObjectParameter("user", user) :
            new ObjectParameter("user", typeof(string));


        var passParameter = pass != null ?
            new ObjectParameter("pass", pass) :
            new ObjectParameter("pass", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("usp_GetLogin", userParameter, passParameter);
    }


    public virtual ObjectResult<usp_GetLoginById_Result> usp_GetLoginById(Nullable<long> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("Id", id) :
            new ObjectParameter("Id", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetLoginById_Result>("usp_GetLoginById", idParameter);
    }


    public virtual ObjectResult<usp_GetLoginByName_Result> usp_GetLoginByName(string name)
    {

        var nameParameter = name != null ?
            new ObjectParameter("Name", name) :
            new ObjectParameter("Name", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetLoginByName_Result>("usp_GetLoginByName", nameParameter);
    }


    public virtual ObjectResult<Nullable<long>> usp_GetLoginIdByToken(string token)
    {

        var tokenParameter = token != null ?
            new ObjectParameter("token", token) :
            new ObjectParameter("token", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("usp_GetLoginIdByToken", tokenParameter);
    }


    public virtual ObjectResult<usp_GetRoles_Result> usp_GetRoles(Nullable<long> idCompany)
    {

        var idCompanyParameter = idCompany.HasValue ?
            new ObjectParameter("idCompany", idCompany) :
            new ObjectParameter("idCompany", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetRoles_Result>("usp_GetRoles", idCompanyParameter);
    }


    public virtual ObjectResult<usp_GetRolesByUserId_Result> usp_GetRolesByUserId(Nullable<long> loginId, Nullable<long> companyid)
    {

        var loginIdParameter = loginId.HasValue ?
            new ObjectParameter("LoginId", loginId) :
            new ObjectParameter("LoginId", typeof(long));


        var companyidParameter = companyid.HasValue ?
            new ObjectParameter("companyid", companyid) :
            new ObjectParameter("companyid", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetRolesByUserId_Result>("usp_GetRolesByUserId", loginIdParameter, companyidParameter);
    }


    public virtual ObjectResult<usp_GetSectionByIdModule_Result> usp_GetSectionByIdModule(Nullable<long> idModule)
    {

        var idModuleParameter = idModule.HasValue ?
            new ObjectParameter("idModule", idModule) :
            new ObjectParameter("idModule", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetSectionByIdModule_Result>("usp_GetSectionByIdModule", idModuleParameter);
    }


    public virtual ObjectResult<usp_GetSingleOrder_Result> usp_GetSingleOrder(Nullable<long> id_company, Nullable<long> id_order)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var id_orderParameter = id_order.HasValue ?
            new ObjectParameter("id_order", id_order) :
            new ObjectParameter("id_order", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetSingleOrder_Result>("usp_GetSingleOrder", id_companyParameter, id_orderParameter);
    }


    public virtual ObjectResult<usp_GetUnitByIdComodity_Result> usp_GetUnitByIdComodity(Nullable<long> idComodity)
    {

        var idComodityParameter = idComodity.HasValue ?
            new ObjectParameter("idComodity", idComodity) :
            new ObjectParameter("idComodity", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetUnitByIdComodity_Result>("usp_GetUnitByIdComodity", idComodityParameter);
    }


    public virtual int usp_InsertCommodity(string name, Nullable<long> id_company, string internal_code, string line, string heading, string unit_of_meassure, Nullable<decimal> average_weight)
    {

        var nameParameter = name != null ?
            new ObjectParameter("name", name) :
            new ObjectParameter("name", typeof(string));


        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var internal_codeParameter = internal_code != null ?
            new ObjectParameter("internal_code", internal_code) :
            new ObjectParameter("internal_code", typeof(string));


        var lineParameter = line != null ?
            new ObjectParameter("line", line) :
            new ObjectParameter("line", typeof(string));


        var headingParameter = heading != null ?
            new ObjectParameter("heading", heading) :
            new ObjectParameter("heading", typeof(string));


        var unit_of_meassureParameter = unit_of_meassure != null ?
            new ObjectParameter("unit_of_meassure", unit_of_meassure) :
            new ObjectParameter("unit_of_meassure", typeof(string));


        var average_weightParameter = average_weight.HasValue ?
            new ObjectParameter("average_weight", average_weight) :
            new ObjectParameter("average_weight", typeof(decimal));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertCommodity", nameParameter, id_companyParameter, internal_codeParameter, lineParameter, headingParameter, unit_of_meassureParameter, average_weightParameter);
    }


    public virtual int usp_InsertCustomer(Nullable<long> id_system, Nullable<long> id_company, string name, string address, string zipcode, string city, string iva, string cuit, string phone, string seller, string zone, string route, string custommerType, string activity, string branch, Nullable<decimal> balance)
    {

        var id_systemParameter = id_system.HasValue ?
            new ObjectParameter("id_system", id_system) :
            new ObjectParameter("id_system", typeof(long));


        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var nameParameter = name != null ?
            new ObjectParameter("name", name) :
            new ObjectParameter("name", typeof(string));


        var addressParameter = address != null ?
            new ObjectParameter("address", address) :
            new ObjectParameter("address", typeof(string));


        var zipcodeParameter = zipcode != null ?
            new ObjectParameter("zipcode", zipcode) :
            new ObjectParameter("zipcode", typeof(string));


        var cityParameter = city != null ?
            new ObjectParameter("city", city) :
            new ObjectParameter("city", typeof(string));


        var ivaParameter = iva != null ?
            new ObjectParameter("iva", iva) :
            new ObjectParameter("iva", typeof(string));


        var cuitParameter = cuit != null ?
            new ObjectParameter("cuit", cuit) :
            new ObjectParameter("cuit", typeof(string));


        var phoneParameter = phone != null ?
            new ObjectParameter("phone", phone) :
            new ObjectParameter("phone", typeof(string));


        var sellerParameter = seller != null ?
            new ObjectParameter("seller", seller) :
            new ObjectParameter("seller", typeof(string));


        var zoneParameter = zone != null ?
            new ObjectParameter("zone", zone) :
            new ObjectParameter("zone", typeof(string));


        var routeParameter = route != null ?
            new ObjectParameter("route", route) :
            new ObjectParameter("route", typeof(string));


        var custommerTypeParameter = custommerType != null ?
            new ObjectParameter("custommerType", custommerType) :
            new ObjectParameter("custommerType", typeof(string));


        var activityParameter = activity != null ?
            new ObjectParameter("activity", activity) :
            new ObjectParameter("activity", typeof(string));


        var branchParameter = branch != null ?
            new ObjectParameter("branch", branch) :
            new ObjectParameter("branch", typeof(string));


        var balanceParameter = balance.HasValue ?
            new ObjectParameter("balance", balance) :
            new ObjectParameter("balance", typeof(decimal));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertCustomer", id_systemParameter, id_companyParameter, nameParameter, addressParameter, zipcodeParameter, cityParameter, ivaParameter, cuitParameter, phoneParameter, sellerParameter, zoneParameter, routeParameter, custommerTypeParameter, activityParameter, branchParameter, balanceParameter);
    }


    public virtual ObjectResult<Nullable<long>> usp_insertLogin(string login, Nullable<long> id_company, string email, string password, string phone, Nullable<long> idCustomer)
    {

        var loginParameter = login != null ?
            new ObjectParameter("login", login) :
            new ObjectParameter("login", typeof(string));


        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var emailParameter = email != null ?
            new ObjectParameter("email", email) :
            new ObjectParameter("email", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var phoneParameter = phone != null ?
            new ObjectParameter("phone", phone) :
            new ObjectParameter("phone", typeof(string));


        var idCustomerParameter = idCustomer.HasValue ?
            new ObjectParameter("idCustomer", idCustomer) :
            new ObjectParameter("idCustomer", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("usp_insertLogin", loginParameter, id_companyParameter, emailParameter, passwordParameter, phoneParameter, idCustomerParameter);
    }


    public virtual ObjectResult<string> usp_InsertToken(Nullable<long> id_login)
    {

        var id_loginParameter = id_login.HasValue ?
            new ObjectParameter("id_login", id_login) :
            new ObjectParameter("id_login", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_InsertToken", id_loginParameter);
    }


    public virtual int usp_LinkUserRole(Nullable<long> loginId, Nullable<long> companyId, Nullable<long> roleId)
    {

        var loginIdParameter = loginId.HasValue ?
            new ObjectParameter("LoginId", loginId) :
            new ObjectParameter("LoginId", typeof(long));


        var companyIdParameter = companyId.HasValue ?
            new ObjectParameter("CompanyId", companyId) :
            new ObjectParameter("CompanyId", typeof(long));


        var roleIdParameter = roleId.HasValue ?
            new ObjectParameter("RoleId", roleId) :
            new ObjectParameter("RoleId", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_LinkUserRole", loginIdParameter, companyIdParameter, roleIdParameter);
    }


    public virtual ObjectResult<usp_selectCustomer_Result> usp_selectCustomer(Nullable<long> id_company)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_selectCustomer_Result>("usp_selectCustomer", id_companyParameter);
    }


    public virtual ObjectResult<Nullable<long>> usp_selectSellerNyIdLogin(Nullable<long> userId)
    {

        var userIdParameter = userId.HasValue ?
            new ObjectParameter("UserId", userId) :
            new ObjectParameter("UserId", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("usp_selectSellerNyIdLogin", userIdParameter);
    }


    public virtual int usp_UnLinkUserRole(Nullable<long> loginId, Nullable<long> companyId, Nullable<long> roleId)
    {

        var loginIdParameter = loginId.HasValue ?
            new ObjectParameter("LoginId", loginId) :
            new ObjectParameter("LoginId", typeof(long));


        var companyIdParameter = companyId.HasValue ?
            new ObjectParameter("CompanyId", companyId) :
            new ObjectParameter("CompanyId", typeof(long));


        var roleIdParameter = roleId.HasValue ?
            new ObjectParameter("RoleId", roleId) :
            new ObjectParameter("RoleId", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UnLinkUserRole", loginIdParameter, companyIdParameter, roleIdParameter);
    }


    public virtual ObjectResult<usp_GetCustomerBySystemID_Result> usp_GetCustomerBySystemID(Nullable<long> systemId)
    {

        var systemIdParameter = systemId.HasValue ?
            new ObjectParameter("SystemId", systemId) :
            new ObjectParameter("SystemId", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetCustomerBySystemID_Result>("usp_GetCustomerBySystemID", systemIdParameter);
    }


    public virtual ObjectResult<udp_selectCommodity_Result> udp_selectCommodity(Nullable<long> id_company)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<udp_selectCommodity_Result>("udp_selectCommodity", id_companyParameter);
    }


    public virtual ObjectResult<Nullable<long>> SelectIdCompanyByCUIT(string cuit)
    {

        var cuitParameter = cuit != null ?
            new ObjectParameter("cuit", cuit) :
            new ObjectParameter("cuit", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("SelectIdCompanyByCUIT", cuitParameter);
    }


    public virtual int InsertPrice(Nullable<long> iid_comodity, Nullable<decimal> price, Nullable<long> id_company)
    {

        var iid_comodityParameter = iid_comodity.HasValue ?
            new ObjectParameter("iid_comodity", iid_comodity) :
            new ObjectParameter("iid_comodity", typeof(long));


        var priceParameter = price.HasValue ?
            new ObjectParameter("price", price) :
            new ObjectParameter("price", typeof(decimal));


        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPrice", iid_comodityParameter, priceParameter, id_companyParameter);
    }


    public virtual int TransmitOrder(Nullable<long> idcompany)
    {

        var idcompanyParameter = idcompany.HasValue ?
            new ObjectParameter("idcompany", idcompany) :
            new ObjectParameter("idcompany", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TransmitOrder", idcompanyParameter);
    }


    public virtual ObjectResult<usp_GetOrderDetail_Result> usp_GetOrderDetail(Nullable<long> id_company, Nullable<long> id_order)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        var id_orderParameter = id_order.HasValue ?
            new ObjectParameter("id_order", id_order) :
            new ObjectParameter("id_order", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetOrderDetail_Result>("usp_GetOrderDetail", id_companyParameter, id_orderParameter);
    }


    public virtual ObjectResult<usp_GetOrders_Result> usp_GetOrders(Nullable<long> id_user)
    {

        var id_userParameter = id_user.HasValue ?
            new ObjectParameter("id_user", id_user) :
            new ObjectParameter("id_user", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetOrders_Result>("usp_GetOrders", id_userParameter);
    }


    public virtual ObjectResult<Nullable<long>> ups_InsertOrderHeader(Nullable<long> id_user, Nullable<long> id_customer)
    {

        var id_userParameter = id_user.HasValue ?
            new ObjectParameter("id_user", id_user) :
            new ObjectParameter("id_user", typeof(long));


        var id_customerParameter = id_customer.HasValue ?
            new ObjectParameter("id_customer", id_customer) :
            new ObjectParameter("id_customer", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("ups_InsertOrderHeader", id_userParameter, id_customerParameter);
    }


    public virtual ObjectResult<usp_GetAllOrders_Result> usp_GetAllOrders()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllOrders_Result>("usp_GetAllOrders");
    }


    public virtual ObjectResult<usp_GetAllOrdersByCompany_Result> usp_GetAllOrdersByCompany(Nullable<long> id_company)
    {

        var id_companyParameter = id_company.HasValue ?
            new ObjectParameter("id_company", id_company) :
            new ObjectParameter("id_company", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllOrdersByCompany_Result>("usp_GetAllOrdersByCompany", id_companyParameter);
    }


    public virtual ObjectResult<usp_GetAllOrdersByUser_Result> usp_GetAllOrdersByUser(Nullable<long> id_user)
    {

        var id_userParameter = id_user.HasValue ?
            new ObjectParameter("id_user", id_user) :
            new ObjectParameter("id_user", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllOrdersByUser_Result>("usp_GetAllOrdersByUser", id_userParameter);
    }


    public virtual ObjectResult<usp_GetRolesByLoginId_Result> usp_GetRolesByLoginId(Nullable<long> id_login)
    {

        var id_loginParameter = id_login.HasValue ?
            new ObjectParameter("id_login", id_login) :
            new ObjectParameter("id_login", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetRolesByLoginId_Result>("usp_GetRolesByLoginId", id_loginParameter);
    }


    public virtual ObjectResult<usp_GetOrderDetailByOrderId_Result> usp_GetOrderDetailByOrderId(Nullable<long> id_order)
    {

        var id_orderParameter = id_order.HasValue ?
            new ObjectParameter("id_order", id_order) :
            new ObjectParameter("id_order", typeof(long));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetOrderDetailByOrderId_Result>("usp_GetOrderDetailByOrderId", id_orderParameter);
    }

}

}

