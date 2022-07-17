// This file was generated from JSON Schema using quicktype, do not modify it directly.
// To parse the JSON, add this file to your project and do:
//
//   let photosResponse = try? newJSONDecoder().decode(PhotosResponse.self, from: jsonData)

import Foundation

// MARK: - PhotosResponse
struct PhotosResponse: Codable {
    let photos: Photos?
    let stat: String?
}



