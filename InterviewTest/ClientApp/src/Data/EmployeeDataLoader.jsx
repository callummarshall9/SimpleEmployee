import React, { useEffect, useState } from 'react';
import * as ReactDOM from "react-dom";
import { toODataString } from "@progress/kendo-data-query";

export const EmployeesDataLoader = (props) => {
    const [data, setData] = useState("");

    useEffect(() => {
        async function getData(dataState) {
            const baseUrl = "api/Employees?$count=true&";

            const init = {
                method: "GET",
                accept: "application/json",
                headers: {},
            };

            var odataResponse = await fetch(baseUrl + toODataString(dataState), init);
            var jsonData = await odataResponse.json();

            setData(jsonData.value || 0);

            props.onDataReceived.call(undefined, {
                data: jsonData.value,
                total: jsonData.hasOwnProperty("@odata.count") ? jsonData["@odata.count"] : 0,
            });
        }

        getData(props.dataState);
    }, [props.dataState]);

    return !data
        ? <LoadingPanel />
        : null;
};

const LoadingPanel = () => {
  const loadingPanel = (
    <div className="k-loading-mask">
      <span className="k-loading-text">Loading</span>
      <div className="k-loading-image" />
      <div className="k-loading-color" />
    </div>
    );

  const gridContent = document && document.querySelector(".k-grid-content");
  return gridContent
    ? ReactDOM.createPortal(loadingPanel, gridContent)
    : loadingPanel;
};