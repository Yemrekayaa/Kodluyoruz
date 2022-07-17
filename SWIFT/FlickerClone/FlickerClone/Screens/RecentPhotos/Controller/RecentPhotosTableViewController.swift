//
//  RecentPhotosTableViewController.swift
//  FlickerClone
//
//  Created by Yunus Emre Kaya on 15.07.2022.
//

import UIKit

class RecentPhotosTableViewController: UITableViewController {

    var response: PhotosResponse? {didSet{
        DispatchQueue.main.async {
            self.tableView.reloadData()
        }
       
    }}
    
    var selectedPhoto: Photo?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        title = "Recent Photos"
        setupSearchController()
        fetchRecentPhotos()
        
        
    }
    
    private func fetchRecentPhotos(){
        let recentPhotosString = "https://www.flickr.com/services/rest/?method=flickr.photos.getRecent&api_key=77ec8dbf7fadc2fc5a5c1f99a40fceb0&format=json&nojsoncallback=1&extras=description,date_upload,date_taken,owner_name,icon_server,original_format,last_update,geo,tags,machine_tags,o_dims,views,media,path_alias,url_sq,url_t,url_s,url_q,url_m,url_n,url_z,url_c,url_l,url_o"
        guard let recentPhotosURL = URL(string: recentPhotosString) else {return}
        URLSession.shared.dataTask(with: URLRequest(url: recentPhotosURL)) { data, response, error in
            if let error = error {
                print(error)
                return
            }
            if let data = data, let response = try? JSONDecoder().decode(PhotosResponse.self, from: data) {
                self.response = response
                
            }
        }.resume()
    
    }
    
    private func fetchSearchPhotos(with text:String){
        let recentPhotosString = "https://www.flickr.com/services/rest/?method=flickr.photos.search&api_key=77ec8dbf7fadc2fc5a5c1f99a40fceb0&format=json&nojsoncallback=1&text=\(text)&extras=description,license,date_upload,date_taken,owner_name,icon_server,original_format,last_update,geo,tags,machine_tags,o_dims,views,media,path_alias,url_sq,url_t,url_s,url_q,url_m,url_n,url_z,url_c,url_l,url_o"
        guard let recentPhotosURL = URL(string: recentPhotosString) else {return}
        URLSession.shared.dataTask(with: URLRequest(url: recentPhotosURL)) { data, response, error in
            if let error = error {
                print(error)
                return
            }
            if let data = data, let response = try? JSONDecoder().decode(PhotosResponse.self, from: data) {
                self.response = response
            }
        }.resume()
    }
    
    
    private func setupSearchController(){
        let search = UISearchController(searchResultsController: nil)
        search.searchResultsUpdater = self
        search.obscuresBackgroundDuringPresentation = false
        search.searchBar.placeholder = "Search"
        navigationItem.searchController = search
    }
    
    override func numberOfSections(in tableView: UITableView) -> Int {
        return 1
    }
    
    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return response?.photos?.photo?.count ?? .zero
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let photo = response?.photos?.photo?[indexPath.row]
        
        guard let cell = tableView.dequeueReusableCell(withIdentifier: "Cell", for: indexPath) as? PhotoTableViewCell else {return UITableViewCell()}
        cell.userLabel.text = photo?.ownername
        cell.userImageView.backgroundColor = .darkGray
        cell.photoImageView.backgroundColor = .darkGray
        cell.photoLabel.text = photo?.title
        
        NetworkManager.shared.fetchImage(with: photo?.urlN) { data in
            cell.photoImageView.image = UIImage(data: data)
        }
        
        NetworkManager.shared.fetchImage(with: photo?.bodyIconURL) { data in
            cell.userImageView.image = UIImage(data: data)
        }
        
                
            
        return cell
    }
    
    
    
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        if let photo = response?.photos?.photo?[indexPath.row] {
            selectedPhoto = photo
            performSegue(withIdentifier: "detailSegue", sender: nil)
        }
        
    }
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if let vc = segue.destination as? PhotoDetailViewController{
            vc.photo = selectedPhoto
        }
    }

    
    
}

extension RecentPhotosTableViewController: UISearchResultsUpdating{
    func updateSearchResults(for searchController: UISearchController) {
        guard let text = searchController.searchBar.text else {return}
        if text.count > 2 {
            fetchSearchPhotos(with: text)
        }
    }
    
    
}
